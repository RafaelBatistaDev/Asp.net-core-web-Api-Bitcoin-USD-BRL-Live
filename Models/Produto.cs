namespace API.Models;

public class Produto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Preco { get; set; }
}