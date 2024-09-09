using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using MovieCatalogMVC.Common.PagedList;
using MovieCatalogMVC.Data;
using MovieCatalogMVC.Entities;
using MovieCatalogMVC.Extensions;
using MovieCatalogMVC.Models;

public class GenreController : Controller
{
    private readonly MovieCatalogMVCContext _context;
    private readonly IMapper _mapper;
    private readonly IValidator<Genre> _validator;

    public GenreController(MovieCatalogMVCContext context, IMapper mapper, IValidator<Genre> validator)
    {
        _context = context;
        _mapper = mapper;
        _validator = validator;
    }

    // GET: Genre
    public async Task<IActionResult> Index(int? page)
    {
        int pageNumber = page ?? 1;

        var genres = await _context.Genres
            .OrderBy(g => g.Name)
            .GetPagedAsync(pageNumber);

        var genresModel = _mapper.Map<PagedResult<GenreModel>>(genres);

        return View(genresModel);
    }

    // GET: Genre/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Genre/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(GenreModel genreModel)
    {
        var genre = _mapper.Map<Genre>(genreModel);
        var validator = await _validator.ValidateAsync(genre);

        if (!validator.IsValid)
        {
            validator.AddToModelState(this.ModelState);
            return View(genreModel);
        }

        _context.Add(genre);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    // GET: Genre/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id is null)
            return NotFound();

        var genre = await _context.Genres
            .FindAsync(id);

        if (genre is null)
            return NotFound();

        var genreModel = _mapper.Map<GenreModel>(genre);

        return View(genreModel);
    }

    // POST: Genre/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, GenreModel genreModel)
    {
        if (id != genreModel.GenreId)
            return NotFound();

        var genre = _mapper.Map<Genre>(genreModel);
        var validator = await _validator.ValidateAsync(genre);

        if (!validator.IsValid)
        {
            validator.AddToModelState(this.ModelState);
            return View(genreModel);
        }

        _context.Update(genre);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    // GET: Genre/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id is null)
            return NotFound();

        var genre = await _context.Genres
            .FindAsync(id);

        if (genre is null)
            return NotFound();

        var genreModel = _mapper.Map<GenreModel>(genre);

        return View(genreModel);
    }

    // POST: Genre/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var genre = await _context.Genres.FindAsync(id);
        if (genre is not null)
        {
            _context.Genres.Remove(genre);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }
}
