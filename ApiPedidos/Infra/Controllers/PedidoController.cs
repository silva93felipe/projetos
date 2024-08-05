using ApiPedidos.Contratos;
using ApiPedidos.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ApiPedidos.Controllers;

[ApiController]
[Route("[controller]")]
public class PedidoController : ControllerBase
{
    private readonly IPedidoService _pedidoService;
    private readonly IProjetoService _projetoService;
    public PedidoController(IPedidoService pedidoService, IProjetoService projetoService)
    {
        _pedidoService = pedidoService;
        _projetoService = projetoService;
    }
    [HttpPost]
    public IActionResult Create(PedidoDto pedidoDto)
    {
        _pedidoService.Create(pedidoDto);
        return Created("", new HttpReponse("OK"));
    }

    [HttpGet]
    public void GetAllProjetos()
    {
        _projetoService.GetAll();
    }
}
