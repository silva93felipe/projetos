using ApiProjetos.Context;
using ApiProjetos.Contratos;
using ApiProjetos.Models;

namespace ApiProjetos.Repositories;

public class ProjetoRepositoryInMemory : IProjetoRepository{
    private static readonly List<Projeto> Projetos = new List<Projeto>();
    public void Create(Projeto projeto){
        Projetos.Add(projeto);
    }

    public IEnumerable<Projeto> GetAll() => Projetos;
}