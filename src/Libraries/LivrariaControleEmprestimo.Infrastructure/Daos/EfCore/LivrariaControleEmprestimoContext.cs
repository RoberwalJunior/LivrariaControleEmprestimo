using Microsoft.EntityFrameworkCore;
using LivrariaControleEmprestimo.Domain.Entities;

namespace LivrariaControleEmprestimo.Infrastructure.Daos.EfCore;

public class LivrariaControleEmprestimoContext : DbContext
{
    public LivrariaControleEmprestimoContext(DbContextOptions<LivrariaControleEmprestimoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Livro> Livros { get; set; }
    public virtual DbSet<Cliente> Clientes { get; set; }
    public virtual DbSet<LivroClienteEmprestimo> Emprestimos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LivroClienteEmprestimo>()
            .HasKey(emprestimo => new { emprestimo.LivroId, emprestimo.ClienteId });

        modelBuilder.Entity<LivroClienteEmprestimo>()
            .HasOne(emprestimo => emprestimo.Livro)
            .WithMany(livro => livro.Emprestimos)
            .HasForeignKey(emprestimo => emprestimo.LivroId);

        modelBuilder.Entity<LivroClienteEmprestimo>()
            .HasOne(emprestimo => emprestimo.Cliente)
            .WithMany(cliente => cliente.Emprestimos)
            .HasForeignKey(emprestimo => emprestimo.ClienteId);
    }
}
