using LivrariaControleEmprestimo.Domain.Dtos;

namespace LivrariaControleEmprestimo.Domain.Interfaces.Services.Handlers;

public interface IDefaultClienteService : IDefaultReadDtoService<ReadClienteDto>,
    IDefaultCreateDtoService<CreateClienteDto>, IDefaultUpdateDtoService<UpdateClienteDto>,
    IDefaultDeleteService
{
}
