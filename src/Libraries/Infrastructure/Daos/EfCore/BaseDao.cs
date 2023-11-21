using Microsoft.EntityFrameworkCore;
using Infrastructure.Daos.Interfaces;

namespace Infrastructure.Daos.EfCore;

public class BaseDao<T> : IDefault<T>, IDisposable where T : class
{
    private readonly LivrariaControleEmprestimoContext _context;

    public BaseDao(LivrariaControleEmprestimoContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _context.Set<T>()
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<T> GetById(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task Include(T model)
    {
        await _context.Set<T>().AddAsync(model);
        await Save();
    }

    public async Task Update(T model)
    {
        _context.Entry(model).State = EntityState.Modified;
        await Save();
    }

    public async Task Delete(T model)
    {
        _context.Set<T>().Remove(model);
        await Save();
    }

    private async Task Save()
    {
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
