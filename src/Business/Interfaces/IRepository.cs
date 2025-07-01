
using System.Linq.Expressions;
using Business.Models;

namespace Business.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task<TEntity?> ObterPorIdAsync(Guid id);
        Task<List<TEntity>> ObterTodosAsync();
        Task AdicionarAsync(TEntity entity);
        Task AtualizarAsync(TEntity entity);
        Task RemoverAsync(Guid id);
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChangesAsync();
    }
}
