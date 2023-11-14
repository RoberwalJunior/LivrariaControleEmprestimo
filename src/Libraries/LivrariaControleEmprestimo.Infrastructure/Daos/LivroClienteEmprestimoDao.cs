using LivrariaControleEmprestimo.Domain.Entities;
using LivrariaControleEmprestimo.Infrastructure.Daos.EfCore;
using LivrariaControleEmprestimo.Infrastructure.Interfaces.Handlers;

namespace LivrariaControleEmprestimo.Infrastructure.Daos;

public class LivroClienteEmprestimoDao : BaseDao<LivroClienteEmprestimo>, ILivroClienteEmprestimoDao
{
    public LivroClienteEmprestimoDao(LivrariaControleEmprestimoContext context) : base(context)
    {
    }
}
