using Business.Models;

namespace Business.Interfaces
{
    public interface ISetupService : IDisposable
    {
        Task Adicionar(Setup setup);
        Task Atualizar(Setup setup);
        Task Remover(Guid id);
    }
}
