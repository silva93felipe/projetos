using ApiPedidos.Contratos;
using ApiPedidos.Dto;
using ApiPedidos.Models;

namespace ApiPedidos.Service;
public class PedidoService : IPedidoService{
    private readonly IBus _producer;
    private readonly IPedidoRepository _pedidoRepository;
    public PedidoService(IPedidoRepository pedidoRepository, IBus producer)
    {
        _pedidoRepository = pedidoRepository;
        _producer = producer;
    }
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