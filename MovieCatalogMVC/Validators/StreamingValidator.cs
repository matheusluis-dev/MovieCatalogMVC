using FluentValidation;
using MovieCatalogMVC.Entities;

namespace MovieCatalogMVC.Validators;

public class StreamingValidator : AbstractValidator<Streaming>
{
    public StreamingValidator()
    {
        RuleFor(g => g.Name)
            .NotEmpty().WithMessage("Name is required.")
            .Length(1, 20).WithMessage("Name must be between 1 and 20 characters.")
            .Matches("^[a-zA-Z ]*$").WithMessage("Name can only contain alpha characters and spaces.");
    }
}
