using System.ComponentModel.DataAnnotations;

namespace LivrariaControleEmprestimo.Domain.Dtos;

public class CreateEmprestimoDto
{
    [Required]
    public int ClienteId { get; set; }

    [Required]
    public int LivroId { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime DataEmprestimo { get; set; } = DateTime.Now;

    [DataType(DataType.DateTime)]
    public DateTime DataEntrega { get; set; }
}
