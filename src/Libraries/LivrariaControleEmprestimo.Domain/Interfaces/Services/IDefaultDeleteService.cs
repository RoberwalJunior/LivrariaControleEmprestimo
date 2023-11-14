namespace LivrariaControleEmprestimo.Domain.Interfaces.Services;

public interface IDefaultDeleteService
{
    Task<bool> Deletar(int id);
}
