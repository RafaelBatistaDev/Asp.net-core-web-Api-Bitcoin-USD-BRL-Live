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

    public async Task<decimal> GetPriceAsync(string cryptoId)
    {
        try
        {
            var url = $"https://api.coingecko.com/api/v3/simple/price?ids={cryptoId}&vs_currencies=usd";
            var response = await _httpClient.GetFromJsonAsync<Dictionary<string, Dictionary<string, decimal>>>(url);
            
            if (response != null && response.ContainsKey(cryptoId))
            {
                return response[cryptoId]["usd"];
            }
            return 0;
        }
        catch
        {
            return 0;
        }
    }
}