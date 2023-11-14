using LivrariaControleEmprestimo.Domain.Entities;
using LivrariaControleEmprestimo.Domain.Interfaces.Daos;
using LivrariaControleEmprestimo.Infrastructure.Contexts;
using LivrariaControleEmprestimo.Infrastructure.Daos.EfCore;

namespace LivrariaControleEmprestimo.Infrastructure.Daos;

public class LivroDao : BaseDao<Livro>, ILivroDao
{
    public LivroDao(LivrariaControleEmprestimoContext context) : base(context)
    {
    }
}
