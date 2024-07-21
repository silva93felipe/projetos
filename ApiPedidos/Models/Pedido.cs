namespace ApiPedidos.Models;

public class Pedido{
    public int Id { get; set; }
    public List<PedidoItem> Itens { get; private set; } = new();
    public void AdicionarItem(PedidoItem item){
        Itens.Add(item);
    }
    public void AdicionarItem(List<PedidoItem> item){
        Itens.AddRange(item);
    }
}