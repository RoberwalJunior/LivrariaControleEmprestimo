using LivrariaControleEmprestimo.Domain.Dtos;

namespace LivrariaControleEmprestimo.Services.Interfaces.Handlers;

public interface IDefaultClienteService : IDefaultReadDtoService<ReadClienteDto>,
    IDefaultCreateDtoService<CreateClienteDto>, IDefaultUpdateDtoService<UpdateClienteDto>,
    IDefaultDeleteService
{
}
