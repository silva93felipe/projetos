using ApiPedidos.Models;

namespace ApiPedidos.Contratos
{
    public interface IPedidoRepository
    {
        public void Create(Pedido pedido);
        public void Save();
        public IEnumerable<Pedido> GetAll();
    }
}