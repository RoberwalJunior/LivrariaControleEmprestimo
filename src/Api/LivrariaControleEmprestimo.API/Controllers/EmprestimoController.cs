using Microsoft.AspNetCore.Mvc;
using LivrariaControleEmprestimo.Domain.Dtos;
using LivrariaControleEmprestimo.Services.Interfaces.Handlers;

namespace LivrariaControleEmprestimo.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmprestimoController : ControllerBase
{
    private readonly IDefaultEmprestimoService _emprestimoService;

    public EmprestimoController(IDefaultEmprestimoService emprestimoService)
    {
        _emprestimoService = emprestimoService;
    }

    [HttpGet]
    public async Task<IEnumerable<ReadEmprestimoDto>> RecuperarEmprestimos()
    {
        return await _emprestimoService.SelecionarTodos();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> RecuperaEmprestimoPorId(int id)
    {
        ReadEmprestimoDto emprestimoDto = await _emprestimoService.SelecionarPeloId(id);
        if (emprestimoDto == null) return NotFound();

        return Ok(emprestimoDto);
    }

    [HttpPost]
    public async Task<IActionResult> AdicionarEmprestimo([FromBody] CreateEmprestimoDto emprestimoDto)
    {
        try
        {
            await _emprestimoService.Criar(emprestimoDto);
            return Ok("Emprestimo cadastrado com exito");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AtualizarEmprestimo(int id, [FromBody] UpdateEmprestimoDto emprestimoDto)
    {
        if (await _emprestimoService.Atualizar(id, emprestimoDto)) return NoContent();
        return NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletarEmprestimo(int id)
    {
        if (await _emprestimoService.Deletar(id)) return NoContent();
        return NotFound();
    }
}
