using Domain.Models;
using Infrastructure.Daos.EfCore;
using Infrastructure.Daos.Interfaces.Handlers;

namespace Infrastructure.Daos;

public class EmprestimoDao : BaseDao<Emprestimo>, IEmprestimoDao
{
    public EmprestimoDao(LivrariaControleEmprestimoContext context) : base(context)
    {
    }
}
