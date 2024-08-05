using ApiPedidos.Contratos;
using ApiPedidos.Models;
using ApiProjetos.Context;

namespace ApiPedidos.Repositories;

public class PedidoRepository : IPedidoRepository{
    private readonly PedidoContext _pedidoContext;
    public PedidoRepository(PedidoContext pedidoContext)
    {
        _pedidoContext = pedidoContext;
    }
    public void Create(Pedido pedido){
        _pedidoContext.Add(pedido);
        Save();
    }

    public void Save(){
        _pedidoContext.SaveChanges();
    }

    public IEnumerable<Pedido>  GetAll(){
        return _pedidoContext.Pedido;
    }
}