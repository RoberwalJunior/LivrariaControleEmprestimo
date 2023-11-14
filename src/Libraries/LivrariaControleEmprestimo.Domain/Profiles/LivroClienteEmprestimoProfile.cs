using AutoMapper;
using LivrariaControleEmprestimo.Domain.Dtos;
using LivrariaControleEmprestimo.Domain.Entities;

namespace LivrariaControleEmprestimo.Domain.Profiles;

public class LivroClienteEmprestimoProfile : Profile
{
    public LivroClienteEmprestimoProfile()
    {
        CreateMap<CreateLivroClienteEmprestimoDto, LivroClienteEmprestimo>();
        CreateMap<LivroClienteEmprestimo, ReadLivroClienteEmprestimoDto>()
            .ForMember(emprestimoDto => emprestimoDto.Cliente,
                opt => opt.MapFrom(emprestimo => emprestimo.Cliente))
            .ForMember(emprestimoDto => emprestimoDto.Livro,
                opt => opt.MapFrom(emprestimo => emprestimo.Livro));
        CreateMap<UpdateLivroClienteEmprestimoDto, LivroClienteEmprestimo>();
    }
}
