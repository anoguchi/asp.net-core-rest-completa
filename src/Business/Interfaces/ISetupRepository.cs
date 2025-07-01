using Business.Models;

namespace Business.Interfaces
{
    public interface ISetupRepository : IRepository<Setup>
    {
        Task<IEnumerable<Setup>> ObterPorPerfilId(Guid perfilId);
        Task<Setup?> ObterPorPerfilIdEEquipamentoId(Guid perfilId, Guid equipamentoId);
        Task<IEnumerable<Setup>> ObterPorEquipamentoId(Guid equipamentoId);
        Task<IEnumerable<Setup>> ObterPorPerfilIdEEquipamentoIds(Guid perfilId, IEnumerable<Guid> equipamentoIds);
    }
}
