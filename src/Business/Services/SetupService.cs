
using Business.Interfaces;
using Business.Models;
using Business.Models.Validations;

namespace Business.Services
{
    public class SetupService : BaseService, ISetupService
    {
        private readonly ISetupRepository _setupRepository;

        public SetupService(ISetupRepository setupRepository)
        {
            _setupRepository = setupRepository;
        }
        public async Task Adicionar(Setup setup)
        {
            if (!ExecutarValidacao(new SetupValidation(), setup)) return;
            await _setupRepository.Adicionar(setup);
        }

        public async Task Atualizar(Setup setup)
        {
            if (!ExecutarValidacao(new SetupValidation(), setup)) return;
            await _setupRepository.Atualizar(setup);
        }

        public async Task Remover(Guid id)
        {
            await _setupRepository.Remover(id);
        }

        public void Dispose()
        {
           _setupRepository?.Dispose();
        }

    }
}
