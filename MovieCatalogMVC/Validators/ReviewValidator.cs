using FluentValidation;
using MovieCatalogMVC.Models;

namespace MovieCatalogMVC.Validators
{
    public class ReviewValidator : AbstractValidator<ReviewModel>
    {
        public ReviewValidator()
        {
            RuleFor(m => m.Rate)
                .NotNull().WithMessage("Rate is required.")
                .InclusiveBetween(0, 5).WithMessage("Rate must be between 0 and 5.");
        }
    }
}
