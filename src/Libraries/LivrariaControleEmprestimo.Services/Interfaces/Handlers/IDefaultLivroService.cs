using LivrariaControleEmprestimo.Domain.Dtos;

namespace LivrariaControleEmprestimo.Services.Interfaces.Handlers;

public interface IDefaultLivroService : IDefaultReadDtoService<ReadLivroDto>,
    IDefaultCreateDtoService<CreateLivroDto>, IDefaultUpdateDtoService<UpdateLivroDto>,
    IDefaultDeleteService
{
}
