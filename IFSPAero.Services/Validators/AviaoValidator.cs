using FluentValidation;
using IFSPAero.Domain.Entities;

namespace IFSPAero.Services.Validators
{
    public class AviaoValidator : AbstractValidator<Aviao>
    {
        public AviaoValidator()
        {
            RuleFor(c => c.Imagem)
                .NotEmpty().WithMessage("Por favor coloque uma imagem.")
                .NotNull().WithMessage("Por favor  coloque uma imagem.");
            RuleFor(c => c.Codigo)
                .NotEmpty().WithMessage("Por favor digite o cógido do Avião.")
                .NotNull().WithMessage("Por favor digite o cógido do Avião.");
            RuleFor(c => c.Modelo)
                .NotEmpty().WithMessage("Por favor digite o modelo do Avião.")
                .NotNull().WithMessage("Por favor digite o modelo do Avião.");
            RuleFor(c => c.Situacao)
                .NotEmpty().WithMessage("Por favor digite a situação do Avião.")
                .NotNull().WithMessage("Por favor digite a situação do Avião.");
        }
    }
}
