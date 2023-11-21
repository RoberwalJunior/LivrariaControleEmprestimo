namespace Services.Services.Interfaces;

public interface IDefaultDeleteService
{
    Task<bool> Deletar(int id);
}
