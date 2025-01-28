using FluentValidation;
using IFSPAero.Domain.Entities;

namespace IFSPAero.Services.Validators
{
    public class CompanhiaValidator : AbstractValidator<Companhia>
    {
        public CompanhiaValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor digite o nome da Companhia.")
                .NotNull().WithMessage("Por favor digite o nome da Companhia");
        }
    }
}