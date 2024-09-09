using FluentValidation;
using MovieCatalogMVC.Entities;

namespace MovieCatalogMVC.Validators;

public class GenreValidator : AbstractValidator<Genre>
{
    public GenreValidator()
    {
        RuleFor(g => g.Name)
            .NotEmpty().WithMessage("Name is required.")
            .Length(1, 30).WithMessage("Name must be between 1 and 30 characters.")
            .Matches("^[a-zA-Z ]*$").WithMessage("Name can only contain alpha characters and spaces.");
    }
}
