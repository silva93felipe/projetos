using ApiProjetos.Dto;
using ApiProjetos.Models;

namespace ApiProjetos.Contratos
{
    public interface IProjetoService
    {
        public void Create(ProjetoDto projetoDto);
        public IEnumerable<Pedido> GetAllPedidos();
        public IEnumerable<Pedido> GetAllPedidosByProjetoId(int projetoId);
    }
}  