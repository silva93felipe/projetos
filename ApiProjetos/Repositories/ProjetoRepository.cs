using ApiProjetos.Context;
using ApiProjetos.Contratos;
using ApiProjetos.Models;

namespace ApiProjetos.Repositories;

public class ProjetoRepository : IProjetoRepository{
    private readonly ProjetoContext _projetoContext;

    public ProjetoRepository(ProjetoContext projetoContext)
    {
        _projetoContext = projetoContext;
    }

    public void Create(Projeto projeto){
        _projetoContext.Add(projeto);
    }
    
    public IEnumerable<Pedido> GetAllPedidos(){
        return _projetoContext.Pedido;
    }

    public IEnumerable<Pedido> GetAllPedidosByProjetoId(int projetoId){
        return _projetoContext.Pedido.Where(e => e.Itens.Any(a => a.Projeto.Id == projetoId));
    }
}