using AutoMapper;
using LivrariaControleEmprestimo.Domain.Dtos;
using LivrariaControleEmprestimo.Domain.Entities;

namespace LivrariaControleEmprestimo.Domain.Profiles;

public class ClienteProfile : Profile
{
    public ClienteProfile()
    {
        CreateMap<CreateClienteDto, Cliente>();
        CreateMap<Cliente, ReadClienteDto>();
        CreateMap<UpdateClienteDto, Cliente>();
    }
}
