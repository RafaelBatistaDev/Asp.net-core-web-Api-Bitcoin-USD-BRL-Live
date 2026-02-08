using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MoedasController : ControllerBase
{
    private static List<Moeda> _moedas = new()
    {
        new Moeda { Id = 1, Nome = "Bitcoin", Simbolo = "BTC", Preco = 450000 },
        new Moeda { Id = 2, Nome = "Ethereum", Simbolo = "ETH", Preco = 15000 }
    };

    [HttpGet]
    public ActionResult<List<Moeda>> GetAll() => Ok(_moedas);

    [HttpPost]
    public ActionResult Add(Moeda novaMoeda)
    {
        _moedas.Add(novaMoeda);
        return CreatedAtAction(nameof(GetAll), novaMoeda);
    }
}