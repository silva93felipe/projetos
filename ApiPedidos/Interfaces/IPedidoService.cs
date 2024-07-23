using ApiPedidos.Dto;

namespace ApiPedidos.Contratos;
public interface IPedidoService{
    void Create(PedidoDto pedidoDto);
}