namespace Infrastructure.Daos.Interfaces;

public interface IDefault<T> : IQuery<T>, ICommand<T> where T : class
{
}
