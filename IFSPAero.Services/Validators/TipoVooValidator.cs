using FluentValidation;
using IFSPAero.Domain.Entities;

namespace IFSPAero.Services.Validators
{
    public class TipoVooValidator : AbstractValidator<TipoVoo>
    {
        public TipoVooValidator()
        {
            RuleFor(c => c.Tipo)
                .NotEmpty().WithMessage("Por favor digite o nome da Função.")
                .NotNull().WithMessage("Por favor digite o nome da Função");
        }
    }
}

