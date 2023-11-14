using LivrariaControleEmprestimo.Domain.Entities;
using LivrariaControleEmprestimo.Infrastructure.Daos.EfCore;
using LivrariaControleEmprestimo.Infrastructure.Interfaces.Handlers;

namespace LivrariaControleEmprestimo.Infrastructure.Daos;

public class LivroDao : BaseDao<Livro>, ILivroDao
{
    public LivroDao(LivrariaControleEmprestimoContext context) : base(context)
    {
    }
}
