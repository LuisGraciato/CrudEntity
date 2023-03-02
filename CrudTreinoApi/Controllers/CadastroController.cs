using Azure.Core;
using CrudDomain.Dtos;
using CrudRepository.Dtos;
using CrudTreinoApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace CrudTreinoApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class CadastroController : ControllerBase
{
    private readonly ICadastroService _service;
    public CadastroController(ICadastroService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var informacoes = await _service.BuscaCadastrosAsync();

        return informacoes.Any()
            ? Ok(informacoes)
            : NoContent();
    }

    [HttpGet("ContactID")]
    public async Task<IActionResult> GetByID(int contactid)
    {

        var informacao = await _service.BuscaCadastroAsync(contactid);

        return informacao != null
            ? Ok(informacao)
            : NotFound("Cadastro nao encontrado");
    }

    [HttpPost]
    public async Task<IActionResult> Create(CadastroCreateDto request)
    {
        await _service.AdicionaAsync(request);
        return Ok("Criado com sucesso");
    }

    [HttpPut]
    public async Task<ActionResult> Update(CadastroUpdateDto cadastroUpdate)
    {
        await _service.AtualizarAsync(cadastroUpdate);
        return Ok("Atualizado com sucesso");

    }

    [HttpDelete("ContactID")]
    public async Task<IActionResult> Delete(int contactid)
    {

        await _service.DeletarAsync(contactid);
        return Ok("Deletado com sucesso");
    }
}



