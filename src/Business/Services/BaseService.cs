
using Business.Models;
using FluentValidation;

namespace Business.Services
{
    public abstract class BaseService
    {
        protected void Notificar(string mensagem)
        {

        }
        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) 
            where TV :AbstractValidator<TE>
            where TE : Entity
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid) return true;

            // Lançamento de notificações de erro

            return false;
        }
    }
}
