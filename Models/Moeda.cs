namespace API.Models;

public class Moeda
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Simbolo { get; set; } = string.Empty;
    public decimal Preco { get; set; }
}