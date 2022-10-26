using CH17GenericMinMax;
namespace GenericMinMaxTests;

[TestClass]
public class UnitTest1
{
    //Test arrays
    int[] intArray1 = { 1, 2, 3, 4 };
    int[] intArray2 = { 5, 6, 7, 8 };
    int[] intArray3 = { -1, -2, -3, -4 };
    int[] intArray4 = { -5, -6, -7, -8 };
    int[] intArray5 = { -1, -2, -3, 1, 2, 3 };

    double[] doubleArray1 = { 1.1, 2.2, 3.3, 4.4 };
    double[] doubleArray2 = { 5.5, 6.6, 7.7, 8.8 };
    double[] doubleArray3 = { -1.1, -2.2, -3.3, -4.4 };
    double[] doubleArray4 = { -5.5, -6.6, -7.7, -8.8 };
    double[] doubleArray5 = { 1.1, 2.2, 3.3, -1.1, -2.2, -3.3 };

    string[] stringArray1 = { "apple", "banana", "cantaloupe", "durian" };
    string[] stringArray2 = { "elderberry", "fig", "grape", "huckleberry" };
    string[] stringArray3 = { "imbe", "jackfruit", "kiwi", "lime" };
    string[] stringArray4 = { "mango", "nectarine", "orange", "papaya" };
    string[] stringArray5 = { "quince", "rambutan", "strawberry", "tamarind" };


    [TestMethod]
    public void TestMinimums()
    {
        Assert.AreEqual(Program.Minimum<int>(intArray1), 1);
        Assert.AreEqual(Program.Minimum<int>(intArray2), 5);
        Assert.AreEqual(Program.Minimum<int>(intArray3), -4);
        Assert.AreEqual(Program.Minimum<int>(intArray4), -8);
        Assert.AreEqual(Program.Minimum<int>(intArray5), -3);

        Assert.AreEqual(Program.Minimum<double>(doubleArray1), 1.1);
        Assert.AreEqual(Program.Minimum<double>(doubleArray2), 5.5);
        Assert.AreEqual(Program.Minimum<double>(doubleArray3), -4.4);
        Assert.AreEqual(Program.Minimum<double>(doubleArray4), -8.8);
        Assert.AreEqual(Program.Minimum<double>(doubleArray5), -3.3);

        Assert.AreEqual(Program.Minimum<string>(stringArray1), "apple");
        Assert.AreEqual(Program.Minimum<string>(stringArray2), "elderberry");
        Assert.AreEqual(Program.Minimum<string>(stringArray3), "imbe");
        Assert.AreEqual(Program.Minimum<string>(stringArray4), "mango");
        Assert.AreEqual(Program.Minimum<string>(stringArray5), "quince");
    }
    [TestMethod]
    
    public void TestMaximums()
    {
        Assert.AreEqual(Program.Maximum<int>(intArray1), 4);
        Assert.AreEqual(Program.Maximum<int>(intArray2), 8);
        Assert.AreEqual(Program.Maximum<int>(intArray3), -1);
        Assert.AreEqual(Program.Maximum<int>(intArray4), -5);
        Assert.AreEqual(Program.Maximum<int>(intArray5), 3);

        Assert.AreEqual(Program.Maximum<double>(doubleArray1), 4.4);
        Assert.AreEqual(Program.Maximum<double>(doubleArray2), 8.8);
        Assert.AreEqual(Program.Maximum<double>(doubleArray3), -1.1);
        Assert.AreEqual(Program.Maximum<double>(doubleArray4), -5.5);
        Assert.AreEqual(Program.Maximum<double>(doubleArray5), 3.3);

        Assert.AreEqual(Program.Maximum<string>(stringArray1), "durian");
        Assert.AreEqual(Program.Maximum<string>(stringArray2), "huckleberry");
        Assert.AreEqual(Program.Maximum<string>(stringArray3), "lime");
        Assert.AreEqual(Program.Maximum<string>(stringArray4), "papaya");
        Assert.AreEqual(Program.Maximum<string>(stringArray5), "tamarind");
    }
}
