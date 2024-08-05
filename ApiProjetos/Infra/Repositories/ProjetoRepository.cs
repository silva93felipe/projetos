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

    public IEnumerable<Projeto> GetAll()
    {
        return _projetoContext.Projeto;
    }
}