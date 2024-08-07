using ApiPedidos.Contratos;
using ApiPedidos.Models;
using ApiProjetos.Context;

namespace ApiPedidos.Repositories;

public class PedidoRepositoryInMemory : IPedidoRepository{
    private static readonly List<Pedido> Pedidos = new List<Pedido>();
    public void Create(Pedido pedido){
        Pedidos.Add(pedido);
    }

    public void Save(){
        //_pedidoContext.SaveChanges();
    }

    public IEnumerable<Pedido>  GetAll() => Pedidos;
}