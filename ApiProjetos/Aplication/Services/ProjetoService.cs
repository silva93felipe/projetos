using ApiProjetos.Contratos;
using ApiProjetos.Dto;
using ApiProjetos.Models;
namespace ApiProjetos.Services
{
    public class ProjetoService : IProjetoService{
        private readonly IProjetoRepository _projetoRepository;
        public ProjetoService(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        public void Create(ProjetoDto projetoDto){
            Projeto projeto = new(projetoDto.Nome);
            if( !projeto.IsValid() ){

            }
            _projetoRepository.Create(projeto);
        }

        public IEnumerable<Projeto> GetAll() => _projetoRepository.GetAll();
    }
}