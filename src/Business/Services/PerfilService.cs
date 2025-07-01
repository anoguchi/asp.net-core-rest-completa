
using Business.Interfaces;
using Business.Models;
using Business.Models.Validations;

namespace Business.Services
{
    public class PerfilService : BaseService, IPerfilService
    {
        private readonly IPerfilRepository _perfilRepository;
        public PerfilService(IPerfilRepository perfilRepository)
        {
            _perfilRepository = perfilRepository;
        }
        public async Task Adicionar(Perfil perfil)
        {
            if (!ExecutarValidacao(new PerfilValidation(), perfil) 
                || !ExecutarValidacao(new EnderecoValidation(), perfil.Endereco)) return;

            // Validar se a entidade é consistente

            // Validar se já existe outro fornecedor com o mesmo documento

            await _perfilRepository.Adicionar(perfil);
        }
        public async Task Atualizar(Perfil perfil)
        {
            if (!ExecutarValidacao(new PerfilValidation(), perfil)) return;
            await _perfilRepository.Atualizar(perfil);
        }
        public async Task Remover(Guid id)
        {
            await _perfilRepository.Remover(id);
        }
        public void Dispose()
        {
            _perfilRepository?.Dispose();
        }
    }
}
