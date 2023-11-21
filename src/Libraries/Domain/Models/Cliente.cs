using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Cliente
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(14)]
    public string CPF { get; set; }

    [Required]
    [MaxLength(200)]
    public string Nome { get; set; }

    [Required]
    [MaxLength(200)]
    public string Endereco { get; set; }

    [Required]
    [MaxLength(100)]
    public string Cidade { get; set; }

    [Required]
    [MaxLength(100)]
    public string Bairro { get; set; }

    [Required]
    [MaxLength(50)]
    public string Numero { get; set; }

    [MaxLength(14)]
    public string TelefoneCelular { get; set; }

    [MaxLength(13)]
    public string TelefoneFixo { get; set; }

    public virtual ICollection<Emprestimo> Emprestimos { get; set; }
}
