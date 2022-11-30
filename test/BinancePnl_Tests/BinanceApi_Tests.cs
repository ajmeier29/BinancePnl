using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinancePnl.BinanceApi;

namespace BinancePnl_Tests;

[TestClass]
public class UnitTest1
{
    private string testUrl = "http://127.0.0.1:5000/?coin=MATICUSDT";

    [TestMethod]
    public void GetBinancePnlData_Pass()
    {

        BinanceApiService binanceApiService = new BinanceApiService(testUrl);
        var test = binanceApiService.GetBinancePnlData().Result;   
    }

    [TestMethod]
    public void Serialize_Test()
    {
        Assert.IsTrue(true);
    }


}