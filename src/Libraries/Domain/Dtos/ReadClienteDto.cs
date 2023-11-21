namespace Domain.Dtos;

public class ReadClienteDto
{
    public int Id { get; set; }
    public string CPF { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }
    public string Bairro { get; set; }
    public string Numero { get; set; }
    public string TelefoneCelular { get; set; }
    public string TelefoneFixo { get; set; }
}
