using AutoMapper;
using LivrariaControleEmprestimo.Domain.Dtos;
using LivrariaControleEmprestimo.Domain.Entities;
using LivrariaControleEmprestimo.Infrastructure.Interfaces.Handlers;
using LivrariaControleEmprestimo.Services.Interfaces.Handlers;

namespace LivrariaControleEmprestimo.Services;

public class ClienteService : IDefaultClienteService
{
    private IMapper _mapper;
    private readonly IClienteDao _clienteDao;

    public ClienteService(IMapper mapper, IClienteDao clienteDao)
    {
        _mapper = mapper;
        _clienteDao = clienteDao;
    }

    public async Task<IEnumerable<ReadClienteDto>> SelecionarTodos()
    {
        IEnumerable<Cliente> list = await _clienteDao.GetAll();
        return _mapper.Map<List<ReadClienteDto>>(list);
    }

    public async Task<ReadClienteDto> SelecionarPeloId(int id)
    {
        Cliente cliente = await _clienteDao.GetById(id);
        if (cliente == null) return null;
        ReadClienteDto clienteDto = _mapper.Map<ReadClienteDto>(cliente);
        return clienteDto;
    }

    public async Task Criar(CreateClienteDto createDto)
    {
        Cliente cliente = _mapper.Map<Cliente>(createDto);
        await _clienteDao.Include(cliente);
    }

    public async Task<bool> Atualizar(int id, UpdateClienteDto updateDto)
    {
        Cliente cliente = await _clienteDao.GetById(id);
        if (cliente == null) return false;
        _mapper.Map(updateDto, cliente);
        await _clienteDao.Update(cliente);
        return true;
    }

    public async Task<bool> Deletar(int id)
    {
        Cliente cliente = await _clienteDao.GetById(id);
        if (cliente == null) return false;
        await _clienteDao.Delete(cliente);
        return true;
    }
}
