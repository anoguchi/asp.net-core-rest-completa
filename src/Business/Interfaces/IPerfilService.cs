
using Business.Models;

namespace Business.Interfaces
{
    public interface IPerfilService : IDisposable
    {
        Task Adicionar(Perfil perfil);
        Task Atualizar(Perfil perfil);
        Task Remover(Guid id);
    }
}
