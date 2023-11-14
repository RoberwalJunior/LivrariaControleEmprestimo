namespace LivrariaControleEmprestimo.Domain.Interfaces.Services;

public interface IDefaultUpdateDtoService<UpdateDto> where UpdateDto : class
{
    Task<bool> Atualizar(int id, UpdateDto updateDto);
}
