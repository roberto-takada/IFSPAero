using FluentValidation;
using IFSPAero.Domain.Entities;

namespace IFSPAero.Services.Validators
{
    public class FuncionarioValidator : AbstractValidator<Funcionario>
    {
        public FuncionarioValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor digite o nome do Funcionário.")
                .NotNull().WithMessage("Por favor digite o nome do Funcionário.");
            RuleFor(c => c.Documento)
                .NotEmpty().WithMessage("Por favor digite o documento do Funcionário.")
                .NotNull().WithMessage("Por favor digite o documento do Funcionário.");
        }
    }
}