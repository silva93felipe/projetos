using ApiPedidos.Dto;
using ApiPedidos.Service;
using Microsoft.AspNetCore.Mvc;

namespace ApiPedidos.Controllers;

[ApiController]
[Route("[controller]")]
public class PedidoController : ControllerBase
{
    private readonly PedidoService _pedidoService = new PedidoService();
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
