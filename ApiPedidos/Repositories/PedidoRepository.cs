using ApiPedidos.Models;

namespace ApiPedidos.Repositories;

public class PedidoRepository{
    private static readonly List<Pedido> pedidos = [];
    public void Create(Pedido pedido){
        pedidos.Add(pedido);
    }
}