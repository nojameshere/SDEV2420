using M1CompetencyBankingAccount;
namespace UnitTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        //Create a temp Account object
        Account testAccount = new Account(5000, 250);
        //Testing Withdrawals
        testAccount["w"] = 100;
        Assert.AreEqual(4650, testAccount.Balance);
        testAccount["w"] = 100;
        Assert.AreEqual(4300, testAccount.Balance);
        testAccount["w"] = 100;
        Assert.AreEqual(3950, testAccount.Balance);
        testAccount["w"] = 100;
        Assert.AreEqual(3600, testAccount.Balance);
        testAccount["w"] = 100;
        Assert.AreEqual(3250, testAccount.Balance);
        //Testing Deposits
        testAccount["d"] = 500;
        Assert.AreEqual(3500, testAccount.Balance);
        testAccount["d"] = 500;
        Assert.AreEqual(3750, testAccount.Balance);
        testAccount["d"] = 500;
        Assert.AreEqual(4000, testAccount.Balance);
        testAccount["d"] = 500;
        Assert.AreEqual(4250, testAccount.Balance);
        testAccount["d"] = 500;
        Assert.AreEqual(4500, testAccount.Balance);
    }
}
