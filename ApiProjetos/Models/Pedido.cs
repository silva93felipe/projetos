namespace ApiProjetos.Models;

public class Pedido{
    public int Id { get; set; }
    public List<PedidoItem> Itens { get; set; } = new();
}