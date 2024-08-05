using ApiProjetos.Dto;
using ApiProjetos.Models;

namespace ApiProjetos.Contratos
{
    public interface IPedidoService
    {
       Task<IEnumerable<PedidoDto>> GetAll();
       Task<IEnumerable<PedidoDto>> GetAllByProjetoId(int projetoId);
    }
}  