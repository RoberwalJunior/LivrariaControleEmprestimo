namespace Services.Services.Interfaces;

public interface IDefaultCreateDtoService<CreateDto> where CreateDto : class
{
    Task Criar(CreateDto createDto);
}
