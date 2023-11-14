namespace LivrariaControleEmprestimo.Infrastructure.Interfaces;

public interface ICommand<T> where T : class
{
    Task Include(T model);
    Task Update(T model);
    Task Delete(T model);
}
