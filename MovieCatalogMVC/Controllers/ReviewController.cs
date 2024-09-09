using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieCatalogMVC.Common.PagedList;
using MovieCatalogMVC.Data;
using MovieCatalogMVC.Entities;
using MovieCatalogMVC.Extensions;
using MovieCatalogMVC.Models;

namespace MovieCatalogMVC.Controllers;

public class ReviewController : Controller
{
    private readonly MovieCatalogMVCContext _context;
    private readonly IMapper _mapper;
    private readonly IValidator<ReviewModel> _validator;
    private readonly UserManager<IdentityUser> _userManager;

    public ReviewController(MovieCatalogMVCContext context, IMapper mapper, IValidator<ReviewModel> validator, UserManager<IdentityUser> userManager)
    {
        _context = context;
        _mapper = mapper;
        _validator = validator;
        _userManager = userManager;
    }

    public async Task<IActionResult> Index(int movieId, int? page)
    {
        int pageNumber = page ?? 1;

        var reviews = await _context.Reviews
            .Where(r => r.MovieId == movieId)
            .Include(r => r.Movie)
            .Include(r => r.User)
            .GetPagedAsync(pageNumber, 5);

        var model = reviews.MapToPagedResultReviewModel(_mapper);

        ViewBag.MovieId = movieId;
        return View(model);
    }

    // GET: Review/Create?movieId=1
    public IActionResult Create(int movieId)
    {
        var model = new ReviewModel { MovieId = movieId };
        return View(model);
    }

    // POST: Review/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(ReviewModel model)
    {
        if (!User.Identity.IsAuthenticated)
        {
            return RedirectToAction("Login", "Account");
        }

        var user = await _userManager.GetUserAsync(User);
        if (user is null)
        {
            return RedirectToAction("Login", "Account");
        }

        var validationResult = await _validator.ValidateAsync(model);
        if (!validationResult.IsValid)
        {
            validationResult.AddToModelState(this.ModelState);
            return View(model);
        }

        var review = _mapper.Map<Review>(model);
        review.ReviewDate = DateTime.Now;
        review.User = user;
        review.Comment ??= string.Empty;
        review.Movie = await _context.Movies.FindAsync(review.MovieId);

        _context.Reviews.Add(review);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index), new { movieId = model.MovieId });
    }
}
