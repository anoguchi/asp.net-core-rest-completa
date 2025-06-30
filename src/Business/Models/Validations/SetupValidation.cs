using FluentValidation;

namespace Business.Models.Validations
{
    public class SetupValidation : AbstractValidator<Setup>
    {
        public SetupValidation() 
        {
            RuleFor(s => s.Mouse)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} é obrigatório")
                .Length(2, 100)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
            RuleFor(s => s.MousePad)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} é obrigatório")
                .Length(2, 100)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
            RuleFor(s => s.Monitor)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} é obrigatório")
                .Length(2, 100)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
            RuleFor(s => s.Teclado)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} é obrigatório")
                .Length(2, 100)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
            RuleFor(s => s.Resolucao)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} é obrigatório")
                .Length(2, 100)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
        }
    }
}
