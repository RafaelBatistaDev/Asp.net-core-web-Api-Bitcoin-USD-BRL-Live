using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class Moeda
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome da moeda é obrigatório")]
    [StringLength(50)]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "O símbolo é obrigatório (ex: BTC)")]
    [StringLength(10)]
    public string Simbolo { get; set; } = string.Empty;

    [Range(0.00000001, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
    public decimal Preco { get; set; }
}