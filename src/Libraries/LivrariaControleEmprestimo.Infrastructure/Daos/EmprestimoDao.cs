using LivrariaControleEmprestimo.Domain.Entities;
using LivrariaControleEmprestimo.Infrastructure.Daos.EfCore;
using LivrariaControleEmprestimo.Infrastructure.Interfaces.Handlers;

namespace LivrariaControleEmprestimo.Infrastructure.Daos;

public class EmprestimoDao : BaseDao<Emprestimo>, IEmprestimoDao
{
    public EmprestimoDao(LivrariaControleEmprestimoContext context) : base(context)
    {
    }
}
