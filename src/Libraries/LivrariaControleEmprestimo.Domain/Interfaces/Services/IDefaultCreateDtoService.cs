namespace LivrariaControleEmprestimo.Domain.Interfaces.Services;

public interface IDefaultCreateDtoService<CreateDto> where CreateDto : class
{
    Task Criar(CreateDto createDto);
}
