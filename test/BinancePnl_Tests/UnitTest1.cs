using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinancePnl_Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestShould_Fail()
    {
        Assert.IsFalse(false);
    }

    [TestMethod]
    public void TestShould_Pass()
    {
        Assert.IsTrue(true);
    }


}