
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



            if (_perfilRepository.Buscar(p => p.Documento == perfil.Documento).Result.Any())
            {
                Notificar("Já existe um perfil com este documento informado");
                return;
            }

            await _perfilRepository.Adicionar(perfil);
        }
        public async Task Atualizar(Perfil perfil)
        {
            if (!ExecutarValidacao(new PerfilValidation(), perfil)) return;

            if (_perfilRepository.Buscar(p => p.Documento == perfil.Documento && p.Id != perfil.Id).Result.Any())
            {
                Notificar("Já existe um perfil com este documento informado");
                return;
            }

            await _perfilRepository.Atualizar(perfil);
        }
        public async Task Remover(Guid id)
        {
            var perfil = await _perfilRepository.ObterPorId(id);

            if (perfil == null)
            {
                Notificar("Perfil não encontrado");
                return;
            }

            if (perfil.Gear.Any())
            {
                Notificar("O perfil possui gear cadastrado!");
                return;
            }

            var endereco = await _perfilRepository.ObterEnderecoPorPerfil(id);

            if (endereco != null)
            {
                await _perfilRepository.RemoverEnderecoPerfil(endereco);
            }

            await _perfilRepository.Remover(id);
        }
        public void Dispose()
        {
            _perfilRepository?.Dispose();
        }
    }
}
