using System.ComponentModel.DataAnnotations;

namespace LivrariaControleEmprestimo.Domain.Entities;

public class Livro
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Nome { get; set; }

    [Required]
    [StringLength(200)]
    public string Autor { get; set; }

    [Required]
    [StringLength(100)]
    public string Editora { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime AnoPublicacao { get; set; }

    [StringLength(50)]
    public string Edicao { get; set; }

    public virtual ICollection<LivroClienteEmprestimo> Emprestimos { get; set; }
}
