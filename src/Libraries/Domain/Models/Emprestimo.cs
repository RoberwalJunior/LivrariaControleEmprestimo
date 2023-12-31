﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Emprestimo
{
    public int ClienteId { get; set; }
    public virtual Cliente Cliente { get; set; }

    public int LivroId { get; set; }
    public virtual Livro Livro { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime DataEmprestimo { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime DataEntrega { get; set; }

    public bool Entregue { get; set; }
}
