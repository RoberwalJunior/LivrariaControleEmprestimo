using System.ComponentModel.DataAnnotations;

namespace LivrariaWeb.Models;

public class ClienteViewModel
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "{0} é obrigatório!")]
    [StringLength(14)]
    public string CPF { get; set; }

    [Required(ErrorMessage = "{0} é obrigatório!")]
    [StringLength(200)]
    public string Nome { get; set; }

    [Required(ErrorMessage = "{0} é obrigatório!")]
    [StringLength(200)]
    [Display(Name = "Endereço")]
    public string Endereco { get; set; }

    [Required(ErrorMessage = "{0} é obrigatório!")]
    [StringLength(100)]
    public string Cidade { get; set; }

    [Required(ErrorMessage = "{0} é obrigatório!")]
    [StringLength(100)]
    public string Bairro { get; set; }

    [Required(ErrorMessage = "{0} é obrigatório!")]
    [StringLength(50)]
    public string Numero { get; set; }

    [StringLength(14)]
    [Display(Name = "Celular")]
    public string TelefoneCelular { get; set; }

    [StringLength(13)]
    [Display(Name = "Fixo")]
    public string TelefoneFixo { get; set; }
}
