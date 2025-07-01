using Business.Models;

namespace Business.Interfaces
{
    public interface IPerfilRepository : IRepository<Perfil>
    {
        Task<Perfil?> ObterPorDocumentoAsync(string documento);
        Task<Perfil?> ObterPorEmailAsync(string email);
        Task<Endereco> ObterEnderecoPorPerfil(Guid id);
        Task<IEnumerable<Perfil>> ObterTodosAtivosAsync();
        Task<IEnumerable<Perfil>> ObterPorTipoPerfilAsync(TipoPerfil tipoPerfil);
        Task<IEnumerable<Perfil>> ObterPorNomeAsync(string nome);
    }
}
