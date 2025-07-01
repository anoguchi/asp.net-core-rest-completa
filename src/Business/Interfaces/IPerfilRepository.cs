using System.Reflection.Metadata.Ecma335;
using Business.Models;

namespace Business.Interfaces
{
    public interface IPerfilRepository : IRepository<Perfil>
    {
        Task<Perfil?> ObterPorDocumento(string documento);
        Task<Perfil?> ObterPorEmail(string email);
        Task<Endereco?> ObterEnderecoPorPerfil(Guid id);
        Task<IEnumerable<Perfil>> ObterTodosAtivos();
        Task<IEnumerable<Perfil>> ObterPorTipoPerfil(TipoPerfil tipoPerfil);
        Task<IEnumerable<Perfil>> ObterPorNome(string nome);
        Task RemoverEnderecoPerfil(Endereco endereco);
    }
}
