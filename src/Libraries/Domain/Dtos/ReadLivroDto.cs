namespace Domain.Dtos;

public class ReadLivroDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Autor { get; set; }
    public string Editora { get; set; }
    public DateTime AnoPublicacao { get; set; }
    public string Edicao { get; set; }
}
