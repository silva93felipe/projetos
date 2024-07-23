using ApiProjetos.Contratos;
using ApiProjetos.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjetos.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjetoController : ControllerBase
{
    private readonly IProjetoService _projetoService;
    public ProjetoController(IProjetoService projetoService)
    {
        _projetoService = projetoService;
    }

    [HttpPost]
    public IActionResult Create(ProjetoDto projetoDto)
    {
        _projetoService.Create(projetoDto);
        return Created(string.Empty, new HttpReponse("OK"));
    }

    [HttpGet]
    [Route("GetAllPedidos")]
    public IActionResult GetAllPedidos()
    {
        return Ok(new HttpReponse("OK", _projetoService.GetAllPedidos()));
    }

    [HttpGet("{projetoId:int}")]
    [Route("GetAllPedidos")]
    public IActionResult GetAllPedidosByProjetoId(int projetoId)
    {
        return Ok(new HttpReponse("OK", _projetoService.GetAllPedidosByProjetoId(projetoId)));
    }
}
