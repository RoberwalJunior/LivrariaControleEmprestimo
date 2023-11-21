using Domain.Dtos;
using Microsoft.AspNetCore.Mvc;
using Services.Services.Interfaces.Handlers;

namespace LivrariaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LivroController : ControllerBase
{
    private readonly IDefaultLivroService _livroService;

    public LivroController(IDefaultLivroService clienteService)
    {
        _livroService = clienteService;
    }

    [HttpGet]
    public async Task<IEnumerable<ReadLivroDto>> RecuperarLivros()
    {
        return await _livroService.SelecionarTodos();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> RecuperaLivroPorId(int id)
    {
        ReadLivroDto livroDto = await _livroService.SelecionarPeloId(id);
        if (livroDto == null) return NotFound();

        return Ok(livroDto);
    }

    [HttpPost]
    public async Task<IActionResult> AdicionarLivro([FromBody] CreateLivroDto livroDto)
    {
        try
        {
            await _livroService.Criar(livroDto);
            return Ok("Livro cadastrado com exito");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AtualizarLivro(int id, [FromBody] UpdateLivroDto livroDto)
    {
        if (await _livroService.Atualizar(id, livroDto)) return NoContent();
        return NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletarLivro(int id)
    {
        if (await _livroService.Deletar(id)) return NoContent();
        return NotFound();
    }
}
