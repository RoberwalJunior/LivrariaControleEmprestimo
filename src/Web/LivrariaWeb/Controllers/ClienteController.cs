using LivrariaWeb.Models;
using LivrariaWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaWeb.Controllers;

public class ClienteController : Controller
{
    private readonly ClienteApiService _clienteApi;

    public ClienteController(ClienteApiService clienteApi)
    {
        _clienteApi = clienteApi;
    }

    public async Task<IActionResult> Index()
    {
        List<ClienteViewModel> clientes = await _clienteApi.RecuperarClientes();

        if (clientes == null)
        {
            ModelState.AddModelError(null, "Erro ao processar a solicitação");
        }

        return View(clientes);
    }

    public async Task<IActionResult> Details(int id)
    {
        ClienteViewModel cliente = await _clienteApi.RecuperarClientePeloId(id);

        if (cliente == null)
        {
            ModelState.AddModelError(null, "Erro ao processar a solicitação");
        }

        return View(cliente);
    }
}
