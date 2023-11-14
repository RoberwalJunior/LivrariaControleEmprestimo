using AutoMapper;
using LivrariaControleEmprestimo.Domain.Dtos;
using LivrariaControleEmprestimo.Domain.Entities;

namespace LivrariaControleEmprestimo.Domain.Profiles;

public class LivroProfile : Profile
{
    public LivroProfile()
    {
        CreateMap<CreateLivroDto, Livro>();
        CreateMap<Livro, ReadLivroDto>();
        CreateMap<UpdateLivroDto, Livro>();
    }
}
