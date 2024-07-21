using ApiProjetos.Dto;
using ApiProjetos.Models;
using ApiProjetos.Repositories;

namespace ApiProjetos.Services
{
    public class ProjetoService{
        private readonly ProjetoRepository _projetoRepository = new();
        public void Create(ProjetoDto projetoDto){
            Projeto projeto = new(projetoDto.Nome);
            if( !projeto.IsValid() ){

            }
            _projetoRepository.Create(projeto);
        }

        public IEnumerable<Pedido> GetAllPedidos(){
            return Enumerable.Empty<Pedido>();
        }

        public IEnumerable<Pedido> GetAllPedidosByProjetoId(int projetoId){
            return Enumerable.Empty<Pedido>();
        }
    }
}