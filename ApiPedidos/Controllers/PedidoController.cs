using ApiPedidos.Contratos;
using ApiPedidos.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ApiPedidos.Controllers;

[ApiController]
[Route("[controller]")]
public class PedidoController : ControllerBase
{
    private readonly IPedidoService _pedidoService;
    public PedidoController(IPedidoService pedidoService)
    {
        _pedidoService = pedidoService;
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
    }
}
