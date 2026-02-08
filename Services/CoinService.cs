namespace API.Services;

public class CoinService
{
    private readonly HttpClient _httpClient;

    public CoinService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        // Identificação necessária para APIs públicas
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "RecifeCryptoAPI");
    }

    // Agora retorna um dicionário com múltiplas moedas (usd, brl)
    public async Task<Dictionary<string, decimal>?> GetPricesAsync(string cryptoId)
    {
        try
        {
            // Adicionamos ",brl" na query string da URL
            var url = $"https://api.coingecko.com/api/v3/simple/price?ids={cryptoId.ToLower()}&vs_currencies=usd,brl";
            
            var response = await _httpClient.GetFromJsonAsync<Dictionary<string, Dictionary<string, decimal>>>(url);
            
            if (response != null && response.ContainsKey(cryptoId.ToLower()))
            {
                return response[cryptoId.ToLower()];
            }
            return null;
        }
        catch
        {
            return null;
        }
    }
}