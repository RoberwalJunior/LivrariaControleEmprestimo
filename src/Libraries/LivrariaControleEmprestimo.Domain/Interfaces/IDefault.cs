namespace LivrariaControleEmprestimo.Domain.Interfaces;

public interface IDefault<T> : IQuery<T>, ICommand<T> where T : class
{
}
