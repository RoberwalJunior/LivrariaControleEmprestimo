namespace LivrariaControleEmprestimo.Domain.Interfaces.Services;

public interface IDefaultReadDtoService<ReadDto> where ReadDto : class
{
    Task<IEnumerable<ReadDto>> SelecionarTodos();
    Task<ReadDto> SelecionarPeloId(int id);
}
