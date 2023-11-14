using LivrariaControleEmprestimo.Domain.Dtos;

namespace LivrariaControleEmprestimo.Domain.Interfaces.Services.Handlers;

public interface IDefaultLivroService : IDefaultReadDtoService<ReadLivroDto>,
    IDefaultCreateDtoService<CreateLivroDto>, IDefaultUpdateDtoService<UpdateLivroDto>,
    IDefaultDeleteService
{
}
