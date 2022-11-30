// This class is the DTO for the binance-pnl-<environment>.trades table. 
using Newtonsoft;
using Newtonsoft.Json;

namespace BinancePnl;

public class Trades
{
    [JsonProperty("OrderID")]
    public string? OrderID { get;set; }
    // public DateTime? ImportDate { get; set; }
    [JsonProperty("OrderType")]
    public string? OrderType { get; set; }
    [JsonProperty("Symbol")]
    public string? Symbol { get; set; }
    [JsonProperty("Side")]
    public string? Side { get; set; }
    [JsonProperty("Price")]
    public decimal? Price { get; set; }
    [JsonProperty("Qty")]
    public int? Qty { get; set; }
    [JsonProperty("Commission")]
    public decimal? Commission { get; set; } 
    [JsonProperty("RealizedPnl")]
    public decimal? RealizedPnl { get; set; }
    [JsonProperty("TotalPnL")]
    public decimal? TotalPnL { get; set; }
    // public decimal? EquityCurve { get; set; }
}

public class TradesViewModel
{
    public string? OrderType { get; set; }
    public string? Symbol { get; set; }
    public string? Side { get; set; }
    public decimal Price { get; set; }
    public int Qty { get; set; }
    public decimal Commission { get; set; } 
    public decimal RealizedPnl { get; set; }
    public decimal TotalPnl { get; set; }
    public decimal EquityCurve { get; set; }
}


