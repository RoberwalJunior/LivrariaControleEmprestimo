namespace LivrariaControleEmprestimo.Domain.Dtos;

public class ReadLivroClienteEmprestimoDto
{
    public ReadClienteDto Cliente { get; set; }
    public ReadLivroDto Livro { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime DataEntrega { get; set; }
    public bool Entregue { get; set; }
}
