using Business.Models.Validations.Documentos;
using FluentValidation;

namespace Business.Models.Validations
{
    public class PerfilValidation : AbstractValidator<Perfil>
    {
        public PerfilValidation()
        {
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} é obrigatório")
                .Length(2, 200)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("O campo {PropertyName} é obrigatório")
                .EmailAddress().WithMessage("O campo {PropertyName} está em formato inválido");

            When(p => p.TipoPerfil == TipoPerfil.ProPlayer, () =>
            {
                RuleFor(p => p.Documento.Length).Equal(ValidationDocumentos.CnpjValidacao.TamanhoCnpj)
                    .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}");
                RuleFor(p => ValidationDocumentos.CnpjValidacao.Validar(p.Documento)).Equal(true)
                    .WithMessage("O campo Documento precisa ser um CNPJ válido");
            });

            When(p => p.TipoPerfil == TipoPerfil.RegularPlayer, () =>
            {
                RuleFor(p => p.Documento.Length).Equal(ValidationDocumentos.CpfValidacao.TamanhoCpf)
                    .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}");
                RuleFor(p => ValidationDocumentos.CpfValidacao.Validar(p.Documento)).Equal(true)
                    .WithMessage("O campo Documento precisa ser um CNPJ válido");
            });
        }
    }
}
