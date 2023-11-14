using AutoMapper;
using LivrariaControleEmprestimo.Domain.Dtos;
using LivrariaControleEmprestimo.Domain.Entities;
using LivrariaControleEmprestimo.Infrastructure.Interfaces.Handlers;
using LivrariaControleEmprestimo.Services.Interfaces.Handlers;

namespace LivrariaControleEmprestimo.Services;

public class LivroLivroClienteEmprestimoEmprestimoService : IDefaultEmprestimoService
{
    private IMapper _mapper;
    private readonly IEmprestimoDao _emprestimoDao;

    public LivroLivroClienteEmprestimoEmprestimoService(IMapper mapper, IEmprestimoDao emprestimoDao)
    {
        _mapper = mapper;
        _emprestimoDao = emprestimoDao;
    }

    public async Task<IEnumerable<ReadEmprestimoDto>> SelecionarTodos()
    {
        IEnumerable<Emprestimo> list = await _emprestimoDao.GetAll();
        return _mapper.Map<List<ReadEmprestimoDto>>(list);
    }

    public async Task<ReadEmprestimoDto> SelecionarPeloId(int id)
    {
        Emprestimo emprestimo = await _emprestimoDao.GetById(id);
        if (emprestimo == null) return null;
        ReadEmprestimoDto emprestimoDto = _mapper.Map<ReadEmprestimoDto>(emprestimo);
        return emprestimoDto;
    }

    public async Task Criar(CreateEmprestimoDto createDto)
    {
        Emprestimo emprestimo = _mapper.Map<Emprestimo>(createDto);
        await _emprestimoDao.Include(emprestimo);
    }

    public async Task<bool> Atualizar(int id, UpdateEmprestimoDto updateDto)
    {
        Emprestimo emprestimo = await _emprestimoDao.GetById(id);
        if (emprestimo == null) return false;
        _mapper.Map(updateDto, emprestimo);
        await _emprestimoDao.Update(emprestimo);
        return true;
    }

    public async Task<bool> Deletar(int id)
    {
        Emprestimo emprestimo = await _emprestimoDao.GetById(id);
        if (emprestimo == null) return false;
        await _emprestimoDao.Delete(emprestimo);
        return true;
    }
}
