using LivrariaControleEmprestimo.Domain.Entities;
using LivrariaControleEmprestimo.Domain.Interfaces.Daos;
using LivrariaControleEmprestimo.Infrastructure.Contexts;
using LivrariaControleEmprestimo.Infrastructure.Daos.EfCore;

namespace LivrariaControleEmprestimo.Infrastructure.Daos;

public class LivroClienteEmprestimoDao : BaseDao<LivroClienteEmprestimo>, ILivroClienteEmprestimoDao
{
    public LivroClienteEmprestimoDao(LivrariaControleEmprestimoContext context) : base(context)
    {
    }
}
