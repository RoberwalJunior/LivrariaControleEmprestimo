using System.ComponentModel.DataAnnotations;

namespace LivrariaControleEmprestimo.Domain.Dtos;

public class CreateLivroDto
{
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
}
