using LivrariaControleEmprestimo.Domain.Dtos;

namespace LivrariaControleEmprestimo.Domain.Interfaces.Services.Handlers;

public interface IDefaultLivroClienteEmprestimoService : IDefaultReadDtoService<ReadLivroClienteEmprestimoDto>,
    IDefaultCreateDtoService<CreateLivroClienteEmprestimoDto>, IDefaultUpdateDtoService<UpdateLivroClienteEmprestimoDto>,
    IDefaultDeleteService
{
}
