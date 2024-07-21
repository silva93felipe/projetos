namespace ApiProjetos.Models;

public class PedidoItem{
    public int Id { get; set; }
    public Projeto Projeto { get; set; }
    public int Quantidade {get; set;}    
}