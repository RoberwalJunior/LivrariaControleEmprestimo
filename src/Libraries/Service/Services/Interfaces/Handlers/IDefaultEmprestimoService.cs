using Domain.Dtos;

namespace Services.Services.Interfaces.Handlers;

public interface IDefaultEmprestimoService : IDefaultReadDtoService<ReadEmprestimoDto>,
    IDefaultCreateDtoService<CreateEmprestimoDto>, IDefaultUpdateDtoService<UpdateEmprestimoDto>,
    IDefaultDeleteService
{
}
