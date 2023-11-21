using Domain.Models;
using Infrastructure.Daos.EfCore;
using Infrastructure.Daos.Interfaces.Handlers;

namespace Infrastructure.Daos;

public class ClienteDao : BaseDao<Cliente>, IClienteDao
{
    public ClienteDao(LivrariaControleEmprestimoContext context) : base(context)
    {
    }
}
