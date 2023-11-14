using LivrariaControleEmprestimo.Domain.Dtos;

namespace LivrariaControleEmprestimo.Services.Interfaces.Handlers;

public interface IDefaultLivroClienteEmprestimoService : IDefaultReadDtoService<ReadLivroClienteEmprestimoDto>,
    IDefaultCreateDtoService<CreateLivroClienteEmprestimoDto>, IDefaultUpdateDtoService<UpdateLivroClienteEmprestimoDto>,
    IDefaultDeleteService
{
}
