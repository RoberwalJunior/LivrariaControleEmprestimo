using AutoMapper;
using LivrariaControleEmprestimo.Domain.Dtos;
using LivrariaControleEmprestimo.Domain.Entities;
using LivrariaControleEmprestimo.Domain.Interfaces.Daos;
using LivrariaControleEmprestimo.Domain.Interfaces.Services.Handlers;

namespace LivrariaControleEmprestimo.Services.Service;

public class LivroService : IDefaultLivroService
{
    private IMapper _mapper;
    private readonly ILivroDao _livroDao;

    public LivroService(IMapper mapper, ILivroDao livroDao)
    {
        _mapper = mapper;
        _livroDao = livroDao;
    }

    public async Task<IEnumerable<ReadLivroDto>> SelecionarTodos()
    {
        IEnumerable<Livro> list = await _livroDao.GetAll();
        return _mapper.Map<List<ReadLivroDto>>(list);
    }

    public async Task<ReadLivroDto> SelecionarPeloId(int id)
    {
        Livro livro = await _livroDao.GetById(id);
        if (livro == null) return null;
        ReadLivroDto livroDto = _mapper.Map<ReadLivroDto>(livro);
        return livroDto;
    }

    public async Task Criar(CreateLivroDto createDto)
    {
        Livro livro = _mapper.Map<Livro>(createDto);
        await _livroDao.Include(livro);
    }

    public async Task<bool> Atualizar(int id, UpdateLivroDto updateDto)
    {
        Livro livro = await _livroDao.GetById(id);
        if (livro == null) return false;
        _mapper.Map(updateDto, livro);
        await _livroDao.Update(livro);
        return true;
    }

    public async Task<bool> Deletar(int id)
    {
        Livro livro = await _livroDao.GetById(id);
        if (livro == null) return false;
        await _livroDao.Delete(livro);
        return true;
    }
}
