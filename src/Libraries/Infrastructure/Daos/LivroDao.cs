using Domain.Models;
using Infrastructure.Daos.EfCore;
using Infrastructure.Daos.Interfaces.Handlers;

namespace Infrastructure.Daos;

public class LivroDao : BaseDao<Livro>, ILivroDao
{
    public LivroDao(LivrariaControleEmprestimoContext context) : base(context)
    {
    }
}
