namespace AccountGrowth;

[TestClass]
public class UnitTest1
{
    Account test1 = new Account(100, 5, 10);
    Account test2 = new Account(100, 5, 20);
    Account test3 = new Account(50, 10, 10);
    Account test4 = new Account(50, 10, 20);
    Account test5 = new Account(1000, 2.6, 100);
    [TestMethod]
    public void TestMethod1()
    {
        Assert.AreEqual(TestAccountGrowth(test1), 162.89, .01);
        Assert.AreEqual(TestAccountGrowth(test2), 265.33, .01);
        Assert.AreEqual(TestAccountGrowth(test3), 129.69, .01);
        Assert.AreEqual(TestAccountGrowth(test4), 336.37, .01);
        Assert.AreEqual(TestAccountGrowth(test5), 13023.75, .01);

    }
    public double TestAccountGrowth(Account account)
    {
        for (int i = 0; i < account.numCycles; i++)
        {
            account.RunCycle();
        }
        return account.CurrentBalance;
    }
}
