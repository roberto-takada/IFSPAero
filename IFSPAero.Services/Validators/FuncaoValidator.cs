using System.Data;
using FluentValidation;
using IFSPAero.Domain.Entities;

namespace IFSPAero.Services.Validators
{
    public class FuncaoValidator : AbstractValidator<Funcao>
    {
        public FuncaoValidator()
        {
            RuleFor(c => c.NomeFuncao)
                .NotEmpty().WithMessage("Por favor digite o nome da Função.")
                .NotNull().WithMessage("Por favor digite o nome da Função");
        }
    }
}

