using System;
using System.Collections.Generic;

namespace BinancePnl.BinanceApi;

public class BinanceApiService
{
    private static string _url;
    

    public BinanceApiService(string url)
    {
        _url = url;     
    }
    
    public async Task<string?> GetBinancePnlData()
    {
        using var client = new HttpClient();
        HttpResponseMessage result = await client.GetAsync(_url);
        var resp = await result.Content.ReadAsStringAsync();
        return resp;
    }
}