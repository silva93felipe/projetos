using ApiPedidos.Dto;
using ApiPedidos.Models;

namespace ApiPedidos.Contratos;
public interface IPedidoService{
    void Create(PedidoDto pedidoDto);
    IEnumerable<Pedido> GetAll();
}