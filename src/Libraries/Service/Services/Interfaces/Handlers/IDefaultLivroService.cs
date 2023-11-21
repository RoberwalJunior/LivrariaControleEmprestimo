using Domain.Dtos;

namespace Services.Services.Interfaces.Handlers;

public interface IDefaultLivroService : IDefaultReadDtoService<ReadLivroDto>,
    IDefaultCreateDtoService<CreateLivroDto>, IDefaultUpdateDtoService<UpdateLivroDto>,
    IDefaultDeleteService
{
}
