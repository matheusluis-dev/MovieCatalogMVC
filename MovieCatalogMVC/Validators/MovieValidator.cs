using FluentValidation;
using MovieCatalogMVC.Entities;
using MovieCatalogMVC.Models;

namespace MovieCatalogMVC.Validators;

public class MovieValidator : AbstractValidator<MovieModel>
{
    public MovieValidator()
    {
        RuleFor(m => m.Title)
            .NotEmpty().WithMessage("Name is required.")
            .Length(1, 50).WithMessage("Name must be between 1 and 50 characters.");

        RuleFor(m => m.ReleaseDate).NotNull().WithMessage("Release Date is required.");

        RuleFor(m => m.GenreId)
            .NotNull().NotEqual(0)
            .WithMessage("Genre is required.");

        RuleFor(m => m.SelectedStreamingIds)
            .NotNull().NotEmpty()
            .WithMessage("Streaming is required.");
    }
}
