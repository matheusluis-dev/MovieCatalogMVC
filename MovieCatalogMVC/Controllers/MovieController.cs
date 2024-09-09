using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieCatalogMVC.Common.PagedList;
using MovieCatalogMVC.Data;
using MovieCatalogMVC.Entities;
using MovieCatalogMVC.Extensions;
using MovieCatalogMVC.Models;

namespace MovieCatalogMVC.Controllers;

public class MovieController : Controller
{
    private readonly MovieCatalogMVCContext _context;
    private readonly IMapper _mapper;
    private readonly IValidator<MovieModel> _validator;

    public MovieController(MovieCatalogMVCContext context, IMapper mapper, IValidator<MovieModel> validator)
    {
        _context = context;
        _mapper = mapper;
        _validator = validator;
    }

    private IQueryable<Movie> QueryMovies()
        => _context.Movies
            .Include(g => g.Genre)
            .Include(g => g.MoviesStreamings)
            .ThenInclude(ms => ms.Streaming)
            .OrderBy(g => g.Title);

    // GET: Movie
    public async Task<IActionResult> Index(int? page)
    {
        int pageNumber = page ?? 1;

        var movies = await QueryMovies()
            .GetPagedAsync(pageNumber);

        var model = movies.MapToPagedResultMovieModel(_mapper);

        return View(model);
    }

    private async Task GetSelectsLoaded()
    {
        var genres = await _context.Genres.OrderBy(g => g.Name).ToListAsync();
        var genresModel = _mapper.Map<IEnumerable<GenreModel>>(genres);
        ViewBag.Genres = new SelectList(genresModel, "GenreId", "Name");

        var streamings = await _context.Streamings.OrderBy(g => g.Name).ToListAsync();
        var streamingsModel = _mapper.Map<IEnumerable<StreamingModel>>(streamings);
        ViewBag.Streamings = new MultiSelectList(streamingsModel, "StreamingId", "Name");
    }

    private async Task<Movie> AddRelationships(MovieModel model)
    {
        var movie = await QueryMovies().FirstOrDefaultAsync(m => m.MovieId == model.MovieId)
            ?? _mapper.Map<Movie>(model);

        movie.Title = model.Title;
        movie.ReleaseDate = model.ReleaseDate;

        movie.MoviesStreamings = new List<MoviesStreamings>();
        foreach (var streamingId in model.SelectedStreamingIds)
        {
            var streamingEntity = await _context.Streamings.FindAsync(streamingId);

            if (streamingEntity is null)
                continue;

            movie.MoviesStreamings.Add(new MoviesStreamings
            {
                Movie = movie,
                Streaming = streamingEntity,
            });
        }

        movie.Genre = await _context.Genres.FindAsync(model.GenreId);

        return movie;
    }

    // GET: Movie/Create
    public async Task<IActionResult> Create()
    {
        await GetSelectsLoaded();
        return View();
    }

    // POST: Movie/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(MovieModel model)
    {
        var validator = await _validator.ValidateAsync(model);

        if (!validator.IsValid)
        {
            validator.AddToModelState(this.ModelState);

            await GetSelectsLoaded();
            return View(model);
        }

        var movie = await AddRelationships(model);

        _context.Add(movie);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    // GET: Genre/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id is null)
            return NotFound();

        var movie = await QueryMovies()
            .FirstOrDefaultAsync(m => m.MovieId == id);

        if (movie is null)
            return NotFound();

        var model = _mapper.Map<MovieModel>(movie);

        await GetSelectsLoaded();
        return View(model);
    }

    // POST: Genre/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, MovieModel model)
    {
        if (id != model.MovieId)
            return NotFound();

        var validator = await _validator.ValidateAsync(model);

        if (!validator.IsValid)
        {
            validator.AddToModelState(this.ModelState);

            await GetSelectsLoaded();
            return View(model);
        }

        var movie = await AddRelationships(model);

        _context.Update(movie);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    // GET: Movie/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id is null)
            return NotFound();

        var movie = await QueryMovies()
            .FirstOrDefaultAsync(m => m.MovieId == id);

        if (movie is null)
            return NotFound();

        var model = _mapper.Map<MovieModel>(movie);

        return View(model);
    }

    // POST: Movie/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var movie = await _context.Movies.FindAsync(id);

        if (movie is not null)
        {
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }
}
