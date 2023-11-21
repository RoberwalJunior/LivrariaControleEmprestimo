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

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        List<ClienteViewModel> clientes = await _clienteApi.RecuperarClientes();

        if (clientes == null)
        {
            ModelState.AddModelError(null, "Erro ao processar a solicitação");
        }

        return View(clientes);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(ClienteViewModel clienteViewModel)
    {
        if (!ModelState.IsValid)
        {
            return View(clienteViewModel);
        }

        try
        {
            if (!await _clienteApi.CriandoCliente(clienteViewModel))
            {
                ModelState.AddModelError(null, "Erro ao processar a solicitação");
                return View(clienteViewModel);
            }

            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    [HttpGet]
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
