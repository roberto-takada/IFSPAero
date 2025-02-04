using FluentValidation;
using IFSPAero.Domain.Entities;

namespace IFSPAero.Services.Validators
{
    public class AeroportoValidator : AbstractValidator<Aeroporto>
    {
        public AeroportoValidator()
        {
            RuleFor(c => c.Cidade)
                .NotEmpty().WithMessage("Por favor digite o nome da Cidade.")
                .NotNull().WithMessage("Por favor digite o nome da Cidade");
            RuleFor(c => c.Pais)
                .NotEmpty().WithMessage("Por favor digite o nome do Pais.")
                .NotNull().WithMessage("Por favor digite o nome do Pais.");
            RuleFor(c => c.Codigo)
                .NotEmpty().WithMessage("Por favor digite o código do Aeroporto")
                .NotNull().WithMessage("Por favor digite o código do Aeroporto");
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor digite o nome do Aeroporto.")
                .NotNull().WithMessage("Por favor digite o nome do Aeroporto");
        }
    }
}
