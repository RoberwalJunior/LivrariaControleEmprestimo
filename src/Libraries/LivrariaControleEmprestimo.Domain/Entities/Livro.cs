using System.ComponentModel.DataAnnotations;

namespace LivrariaControleEmprestimo.Domain.Entities;

public class Livro
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Nome { get; set; }

    [Required]
    [MaxLength(200)]
    public string Autor { get; set; }

    [Required]
    [MaxLength(100)]
    public string Editora { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime AnoPublicacao { get; set; }

    [MaxLength(50)]
    public string Edicao { get; set; }

    public virtual ICollection<Emprestimo> Emprestimos { get; set; }
}
