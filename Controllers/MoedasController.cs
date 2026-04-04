using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;
using API.Services;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MoedasController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly CoinService _coinService;

    public MoedasController(AppDbContext context, CoinService coinService)
    {
        _context = context;
        _coinService = coinService;
    }

    // GET: api/Moedas (Lista as moedas do seu banco local)
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Moeda>>> GetMoedas()
    {
        return await _context.Moedas.ToListAsync();
    }

    // GET: api/Moedas/live/btc (Busca o preço REAL em USD e BRL)
    [HttpGet("live/{simbolo}")]
    public async Task<IActionResult> GetLivePrice(string simbolo)
    {
        string cryptoId = simbolo.ToLower() switch
        {
            "btc" => "bitcoin",
            "eth" => "ethereum",
            "sol" => "solana",
            _ => simbolo.ToLower()
        };

        // Agora chamamos GetPricesAsync (plural) que retorna o dicionário
        var precos = await _coinService.GetPricesAsync(cryptoId);

        if (precos == null) 
            return NotFound("Moeda não encontrada ou erro na API externa.");

        return Ok(new
        {
            Simbolo = simbolo.ToUpper(),
            PrecoUSD = precos["usd"],
            PrecoBRL = precos["brl"], // <--- Agora exibindo o Real!
            Origem = "CoinGecko Real-Time",
            DataConsulta = DateTime.Now
        });
    }

    // POST: api/Moedas (Salva uma moeda no seu banco)
    [HttpPost]
    public async Task<ActionResult<Moeda>> PostMoeda(Moeda moeda)
    {
        _context.Moedas.Add(moeda);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetMoedas), new { id = moeda.Id }, moeda);
    }
}