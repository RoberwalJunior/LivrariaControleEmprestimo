using AutoMapper;
using Domain.Dtos;
using Domain.Models;

namespace Domain.Profiles;

public class EmprestimoProfile : Profile
{
    public EmprestimoProfile()
    {
        CreateMap<CreateEmprestimoDto, Emprestimo>();
        CreateMap<Emprestimo, ReadEmprestimoDto>()
            .ForMember(emprestimoDto => emprestimoDto.Cliente,
                opt => opt.MapFrom(emprestimo => emprestimo.Cliente))
            .ForMember(emprestimoDto => emprestimoDto.Livro,
                opt => opt.MapFrom(emprestimo => emprestimo.Livro));
        CreateMap<UpdateEmprestimoDto, Emprestimo>();
    }
}
