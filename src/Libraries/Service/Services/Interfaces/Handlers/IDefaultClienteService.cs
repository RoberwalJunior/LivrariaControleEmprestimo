using Domain.Dtos;

namespace Services.Services.Interfaces.Handlers;

public interface IDefaultClienteService : IDefaultReadDtoService<ReadClienteDto>,
    IDefaultCreateDtoService<CreateClienteDto>, IDefaultUpdateDtoService<UpdateClienteDto>,
    IDefaultDeleteService
{
}
