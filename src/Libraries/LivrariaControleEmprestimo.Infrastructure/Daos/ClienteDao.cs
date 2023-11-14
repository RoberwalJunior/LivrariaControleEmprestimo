using LivrariaControleEmprestimo.Domain.Entities;
using LivrariaControleEmprestimo.Domain.Interfaces.Daos;
using LivrariaControleEmprestimo.Infrastructure.Daos.EfCore;

namespace LivrariaControleEmprestimo.Infrastructure.Daos;

public class ClienteDao : BaseDao<Cliente>, IClienteDao
{
    public ClienteDao(LivrariaControleEmprestimoContext context) : base(context)
    {
    }
}
