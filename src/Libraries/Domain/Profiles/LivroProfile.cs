using AutoMapper;
using Domain.Dtos;
using Domain.Models;

namespace Domain.Profiles;

public class LivroProfile : Profile
{
    public LivroProfile()
    {
        CreateMap<CreateLivroDto, Livro>();
        CreateMap<Livro, ReadLivroDto>();
        CreateMap<UpdateLivroDto, Livro>();
    }
}
