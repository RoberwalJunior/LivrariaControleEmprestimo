namespace LivrariaControleEmprestimo.Services.Interfaces;

public interface IDefaultDeleteService
{
    Task<bool> Deletar(int id);
}
