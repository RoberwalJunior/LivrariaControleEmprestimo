using LivrariaControleEmprestimo.Domain.Dtos;

namespace LivrariaControleEmprestimo.Services.Interfaces.Handlers;

public interface IDefaultEmprestimoService : IDefaultReadDtoService<ReadEmprestimoDto>,
    IDefaultCreateDtoService<CreateEmprestimoDto>, IDefaultUpdateDtoService<UpdateEmprestimoDto>,
    IDefaultDeleteService
{
}
