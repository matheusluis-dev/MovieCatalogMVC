using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieCatalogMVC.Data;

namespace MovieCatalogMVC.Controllers;

public class QueriesController : Controller
{
    private readonly MovieCatalogMVCContext _context;

    public QueriesController(MovieCatalogMVCContext context)
    {
        _context = context;
    }

    // GET: Queries/StreamingAvailability
    public async Task<IActionResult> StreamingAvailability(string titleFilter = "")
    {
        var query = _context.Movies
            .Include(m => m.MoviesStreamings)
            .ThenInclude(m => m.Streaming)
            .OrderBy(m => m.Title)
            .AsQueryable()
            .AsNoTracking();

        if (!string.IsNullOrWhiteSpace(titleFilter))
        {
            query = query.Where(movie => movie.Title.Contains(titleFilter));
        }

        var result = await query
            .Select(movie => new
            {
                movie.MovieId,
                movie.Title,
                StreamingCount = movie.MoviesStreamings.Count,
                Streamings = string.Join(", ", movie.MoviesStreamings.Select(ms => ms.Streaming.Name)),
            })
            .ToListAsync();

        ViewBag.TitleFilter = titleFilter;
        return View(result);
    }

    // GET: Queries/AverageMovieRates
    public async Task<IActionResult> AverageMovieRates(string titleFilter = "")
    {
        var query = _context.Movies
            .Include(m => m.Reviews)
            .OrderBy(m => m.Title)
            .AsQueryable()
            .AsNoTracking();

        if (!string.IsNullOrWhiteSpace(titleFilter))
        {
            query = query.Where(movie => movie.Title.Contains(titleFilter));
        }

        var result = await query
            .Select(movie => new
            {
                movie.MovieId,
                movie.Title,
                AverageRating = movie.Reviews.Average(review => (double?)review.Rate) ?? 0
            })
            .ToListAsync();

        ViewBag.TitleFilter = titleFilter;
        return View(result);
    }

    // GET: Queries/MoviesByYear
    public async Task<IActionResult> MoviesByYear(int? year)
    {
        int filterYear = year ?? DateTime.Now.Year;

        var movies = await _context.Movies
            .Include(m => m.Genre)
            .Where(m => m.ReleaseDate.HasValue && m.ReleaseDate.Value.Year == filterYear)
            .OrderBy(m => m.Title)
            .AsNoTracking()
            .ToListAsync();

        ViewBag.YearFilter = filterYear;

        return View(movies);
    }

    // GET: Queries/MoviesByRating
    public async Task<IActionResult> MoviesByRate(
        double? minAverageRating,
        double? maxAverageRating,
        string? searchTitle,
        string? searchComment)
    {
        var query = _context.Movies
            .Include(m => m.Reviews)
            .OrderBy(m => m.Title)
            .AsQueryable()
            .AsNoTracking();

        if (minAverageRating.HasValue || maxAverageRating.HasValue)
        {
            query = query
                .Where(m => m.Reviews.Any());

            if (minAverageRating.HasValue)
                query = query.Where(m => m.Reviews.Average(r => r.Rate) >= minAverageRating.Value);

            if (maxAverageRating.HasValue)
                query = query.Where(m => m.Reviews.Average(r => r.Rate) <= maxAverageRating.Value);
        }

        if (!string.IsNullOrWhiteSpace(searchTitle))
            query = query.Where(m => m.Title.Contains(searchTitle));

        if (!string.IsNullOrWhiteSpace(searchComment))
            query = query.Where(m => m.Reviews.Any(r => r.Comment.Contains(searchComment)));

        var movies = await query.ToListAsync();

        ViewBag.MinAverageRating = minAverageRating.ToString();
        ViewBag.MaxAverageRating = maxAverageRating.ToString();
        ViewBag.SearchTitle = searchTitle;
        ViewBag.SearchComment = searchComment;

        return View(movies);
    }

    // GET: Queries/GenreRateByPeriod
    public async Task<IActionResult> GenreRateByPeriod(int? year)
    {
        var query = _context.Movies
            .Where(m => m.ReleaseDate.HasValue && (year == null || m.ReleaseDate.Value.Year == year.Value))
            .OrderBy(m => m.Genre)
            .Include(m => m.Reviews)
            .Include(m => m.Genre)
            .AsQueryable()
            .AsNoTracking();

        var genres = await _context.Genres.ToListAsync();
        genres?.Insert(0, new Entities.Genre { GenreId = 0, Name = string.Empty });
        ViewBag.Genres = new SelectList(genres, "GenreId", "Name");
        ViewBag.Year = year;

        var movies = await query.ToListAsync();
        if (movies is null || movies.Count == 0)
            return View(Enumerable.Empty<dynamic>());

        var genreRatings = movies
            .GroupBy(m => m.Genre.Name)
            .Select(g => new
            {
                Genre = g.Key,
                AverageRating = g.Average(m => m.Reviews.Any() ? m.Reviews.Average(r => (double?)r.Rate) : 0),
                Count = g.Count()
            })
            .ToList();


        return View(genreRatings);
    }
}
