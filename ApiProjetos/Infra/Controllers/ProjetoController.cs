using ApiProjetos.Contratos;
using ApiProjetos.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjetos.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjetoController : ControllerBase
{
    private readonly IProjetoService _projetoService;
    private readonly IPedidoService _pedidoService;
    public ProjetoController(IProjetoService projetoService, IPedidoService pedidoService)
    {
        _projetoService = projetoService;
        _pedidoService = pedidoService;
    }

    [HttpPost]
    public IActionResult Create(ProjetoDto projetoDto)
    {
        _projetoService.Create(projetoDto);
        return Created(string.Empty, new HttpReponse("OK"));
    }
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(new HttpReponse("OK", _projetoService.GetAll()));
    }

    [HttpGet]
    [Route("GetAllPedidos")]
    public async Task<IActionResult> GetAllPedidos()
    {
        return Ok(new HttpReponse("OK", await _pedidoService.GetAll()));
    }

    [HttpGet("{projetoId:int}")]
    [Route("GetAllPedidos")]
    public IActionResult GetAllPedidosByProjetoId(int projetoId)
    {
        return Ok(new HttpReponse("OK", _pedidoService.GetAllByProjetoId(projetoId)));
    }
}
