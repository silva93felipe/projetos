namespace ApiPedidos.Models;

public class PedidoItem{
    public int Id { get; set; }
    public int ProjetoId { get; set; }
    public int Quantidade {get; set;}  
    private PedidoItem(){}
    public PedidoItem(int projetoId, int quantidade)
    {
        ProjetoId = projetoId;
        Quantidade = quantidade;
    }  
}