﻿using FluentValidation;

namespace Business.Models.Validations
{
    public class EnderecoValidation: AbstractValidator<Endereco>
    {
        public EnderecoValidation()
        {
            RuleFor(p => p.Logradouro)
                .NotEmpty().WithMessage("O campo {PropertyName} é obrigatório")
                .Length(2, 200)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
            RuleFor(p => p.Numero)
                .NotEmpty().WithMessage("O campo {PropertyName} é obrigatório")
                .Length(1, 20)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
            RuleFor(p => p.Cep)
                .NotEmpty().WithMessage("O campo {PropertyName} é obrigatório")
                .Length(8)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
            RuleFor(p => p.Bairro)
                .NotEmpty().WithMessage("O campo {PropertyName} é obrigatório")
                .Length(2, 100)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
            RuleFor(p => p.Cidade)
                .NotEmpty().WithMessage("O campo {PropertyName} é obrigatório")
                .Length(2, 100)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
            RuleFor(p => p.Estado)
                .NotEmpty().WithMessage("O campo {PropertyName} é obrigatório")
                .Length(2, 50)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
        }
    }
}
