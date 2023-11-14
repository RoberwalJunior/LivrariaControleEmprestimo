﻿using System.ComponentModel.DataAnnotations;

namespace LivrariaControleEmprestimo.Domain.Entities;

public class Cliente
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(14)]
    public string CPF { get; set; }

    [Required]
    [StringLength(200)]
    public string Nome { get; set; }

    [Required]
    [StringLength(200)]
    public string Endereco { get; set; }

    [Required]
    [StringLength(100)]
    public string Cidade { get; set; }

    [Required]
    [StringLength(100)]
    public string Bairro { get; set; }

    [Required]
    [StringLength(50)]
    public string Numero { get; set; }

    [StringLength(14)]
    public string TelefoneCelular { get; set; }

    [StringLength(13)]
    public string TelefoneFixo { get; set; }

    public virtual ICollection<LivroClienteEmprestimo> Emprestimos { get; set; }
}
