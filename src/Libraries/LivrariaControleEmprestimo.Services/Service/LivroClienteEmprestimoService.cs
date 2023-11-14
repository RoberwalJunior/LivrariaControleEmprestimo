using AutoMapper;
using LivrariaControleEmprestimo.Domain.Dtos;
using LivrariaControleEmprestimo.Domain.Entities;
using LivrariaControleEmprestimo.Domain.Interfaces.Daos;
using LivrariaControleEmprestimo.Domain.Interfaces.Services.Handlers;

namespace LivrariaControleEmprestimo.Services.Service;

public class LivroLivroClienteEmprestimoEmprestimoService : IDefaultLivroClienteEmprestimoService
{
    private IMapper _mapper;
    private readonly ILivroClienteEmprestimoDao _emprestimoDao;

    public LivroLivroClienteEmprestimoEmprestimoService(IMapper mapper, ILivroClienteEmprestimoDao emprestimoDao)
    {
        _mapper = mapper;
        _emprestimoDao = emprestimoDao;
    }

    public async Task<IEnumerable<ReadLivroClienteEmprestimoDto>> SelecionarTodos()
    {
        IEnumerable<LivroClienteEmprestimo> list = await _emprestimoDao.GetAll();
        return _mapper.Map<List<ReadLivroClienteEmprestimoDto>>(list);
    }

    public async Task<ReadLivroClienteEmprestimoDto> SelecionarPeloId(int id)
    {
        LivroClienteEmprestimo emprestimo = await _emprestimoDao.GetById(id);
        if (emprestimo == null) return null;
        ReadLivroClienteEmprestimoDto emprestimoDto = _mapper.Map<ReadLivroClienteEmprestimoDto>(emprestimo);
        return emprestimoDto;
    }

    public async Task Criar(CreateLivroClienteEmprestimoDto createDto)
    {
        LivroClienteEmprestimo emprestimo = _mapper.Map<LivroClienteEmprestimo>(createDto);
        await _emprestimoDao.Include(emprestimo);
    }

    public async Task<bool> Atualizar(int id, UpdateLivroClienteEmprestimoDto updateDto)
    {
        LivroClienteEmprestimo emprestimo = await _emprestimoDao.GetById(id);
        if (emprestimo == null) return false;
        _mapper.Map(updateDto, emprestimo);
        await _emprestimoDao.Update(emprestimo);
        return true;
    }

    public async Task<bool> Deletar(int id)
    {
        LivroClienteEmprestimo emprestimo = await _emprestimoDao.GetById(id);
        if (emprestimo == null) return false;
        await _emprestimoDao.Delete(emprestimo);
        return true;
    }
}
