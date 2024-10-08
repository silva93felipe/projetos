using ApiProjetos.Models;

namespace ApiProjetos.Contratos
{
    public interface IProjetoRepository
    {
        public void Create(Projeto projeto);
        public IEnumerable<Projeto> GetAll();
    }
}