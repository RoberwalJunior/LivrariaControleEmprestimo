using Microsoft.AspNetCore.Mvc;
using LivrariaControleEmprestimo.Domain.Dtos;
using LivrariaControleEmprestimo.Services.Interfaces.Handlers;

namespace LivrariaControleEmprestimo.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClienteController : ControllerBase
{
    private readonly IDefaultClienteService _clienteService;

    public ClienteController(IDefaultClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpGet]
    public async Task<IEnumerable<ReadClienteDto>> RecuperarClientes()
    {
        return await _clienteService.SelecionarTodos();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> RecuperaClientePorId(int id)
    {
        ReadClienteDto clienteDto = await _clienteService.SelecionarPeloId(id);
        if (clienteDto == null) return NotFound();

        return Ok(clienteDto);
    }

    [HttpPost]
    public async Task<IActionResult> AdicionarCliente([FromBody] CreateClienteDto clienteDto)
    {
        try
        {
            await _clienteService.Criar(clienteDto);
            return Ok("Cliente cadastrado com exito");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AtualizarCliente(int id, [FromBody] UpdateClienteDto clienteDto)
    {
        if (await _clienteService.Atualizar(id, clienteDto)) return NoContent();
        return NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletarCliente(int id)
    {
        if (await _clienteService.Deletar(id)) return NoContent();
        return NotFound();
    }
}
