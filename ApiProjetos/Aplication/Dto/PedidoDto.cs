namespace ApiProjetos.Dto;

public class PedidoDto{
     public int Id { get; set; }
    public List<PedidoItem> Itens { get; private set; } = new();
};

public class PedidoItem{
    public int Id { get; set; }
    public int ProjetoId { get; set; }
    public int Quantidade {get; set;}  
}