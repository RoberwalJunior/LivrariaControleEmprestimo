using System.ComponentModel.DataAnnotations;

namespace LivrariaControleEmprestimo.Domain.Dtos;

public class UpdateEmprestimoDto
{
    public int ClienteId { get; set; }

    public int LivroId { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime DataEntrega { get; set; }

    public bool Entregue { get; set; }
}
