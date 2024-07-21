using ApiPedidos.Dto;
using ApiPedidos.Models;
using ApiPedidos.Queue;
using ApiPedidos.Repositories;

namespace ApiPedidos.Service;

public class PedidoService{
    private readonly PedidoRepository _pedidoRepository = new PedidoRepository();
    private readonly Producer _producer = new Producer();
    public void Create(PedidoDto pedidoDto){
        Pedido newPedido = new();
        pedidoDto.Items.ForEach(i => {
            PedidoItem newPedidoItem = new(i.ProjetoId, i.Quantidade);
            newPedido.AdicionarItem(newPedidoItem);
        });
        _pedidoRepository.Create(newPedido);
        _producer.Publish(newPedido);
    }   
}