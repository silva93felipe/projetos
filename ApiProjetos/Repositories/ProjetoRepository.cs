using ApiProjetos.Models;

namespace ApiProjetos.Repositories;

public class ProjetoRepository {
    private static List<Projeto> projetos = new List<Projeto>();
    public void Create(Projeto projeto){
        projetos.Add(projeto);
    }
    
    public IEnumerable<Pedido> GetAllPedidos(){
        return Enumerable.Empty<Pedido>();
    }

    public IEnumerable<Pedido> GetAllPedidosByProjetoId(int projetoId){
        return Enumerable.Empty<Pedido>();
    }
}