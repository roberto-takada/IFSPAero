using FluentValidation;
using IFSPAero.Domain.Entities;

namespace IFSPAero.Services.Validators
{
    public class HangarValidator : AbstractValidator<Hangar>
    {
        public HangarValidator()
        {
            RuleFor(c => c.Codigo)
                .NotEmpty().WithMessage("Por favor digite o código da Função.")
                .NotNull().WithMessage("Por favor digite o código da Função.");
        }
    }
}