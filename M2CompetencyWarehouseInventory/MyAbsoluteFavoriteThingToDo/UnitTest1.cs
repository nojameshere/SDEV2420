namespace MyAbsoluteFavoriteThingToDo;
using TotallyLegitNamespace;
[TestClass]
public class UnitTest1
{
    Warehouse<Product> testWarehouse = new Warehouse<Product>();
    Warehouse<Product> testWarehouse1 = new Warehouse<Product>();
    Warehouse<Product> testWarehouse2 = new Warehouse<Product>();
    Warehouse<Product> testWarehouse3 = new Warehouse<Product>();
    Warehouse<Product> testWarehouse4 = new Warehouse<Product>();
    [TestMethod]
    public void TestMethod1()
    {
        testWarehouse.Push(new Product("Crocus", 123, 248, 4.68));
        testWarehouse.Push(new Product("Poppy", 234, 281, 2.93));
        testWarehouse.Push(new Product("Daisy", 345, 79, 21.88));
        testWarehouse.Push(new Product("Scilla", 456, 110, 2.69));
        testWarehouse.Push(new Product("Marigold", 567, 28, 1.59));
        testWarehouse.Push(new Product("Lavender", 678, 999, .56));
        testWarehouse.Push(new Product("Dahlia", 789, 102, 1.99));
        testWarehouse.Push(new Product("Tulip", 891, 340, 1.03));
        //Push second warehouse
        testWarehouse1.Push(new Product("Crocus", 123, 248, 4.68));
        testWarehouse1.Push(new Product("Poppy", 234, 281, 2.93));
        testWarehouse1.Push(new Product("Daisy", 345, 7, 21.88));
        testWarehouse1.Push(new Product("Scilla", 456, 110, 2.69));
        testWarehouse1.Push(new Product("Marigold", 567, 28, 1.59));
        testWarehouse1.Push(new Product("Lavender", 678, 999, .56));
        testWarehouse1.Push(new Product("Dahlia", 789, 102, 1.99));
        testWarehouse1.Push(new Product("Tulip", 891, 34000, 1.03));
        //Push third warehouse
        testWarehouse2.Push(new Product("Crocus", 123, 248, 4.68));
        testWarehouse2.Push(new Product("Poppy", 234, 281, 2.93));
        testWarehouse2.Push(new Product("Daisy", 345, 7000, 21.88));
        testWarehouse2.Push(new Product("Scilla", 456, 110, 2.69));
        testWarehouse2.Push(new Product("Marigold", 567, 28, 1.59));
        testWarehouse2.Push(new Product("Lavender", 678, 999, .56));
        testWarehouse2.Push(new Product("Dahlia", 789, 102, 1.99));
        testWarehouse2.Push(new Product("Tulip", 891, 1, 1.03));
        //Push fourth warehouse
        testWarehouse3.Push(new Product("Crocus", 123, 248, 4.68));
        testWarehouse3.Push(new Product("Poppy", 234, 281, 2.93));
        testWarehouse3.Push(new Product("Daisy", 345, 79, 21.88));
        testWarehouse3.Push(new Product("Scilla", 456, 1100, 2.69));
        testWarehouse3.Push(new Product("Marigold", 567, 28, 1.59));
        testWarehouse3.Push(new Product("Lavender", 678, 999, .56));
        testWarehouse3.Push(new Product("Dahlia", 789, 102, 1.99));
        testWarehouse3.Push(new Product("Tulip", 891, 3, 1.03));
        //Push fifth warehouse
        testWarehouse4.Push(new Product("Crocus", 123, 4000, 4.68));
        testWarehouse4.Push(new Product("Poppy", 234, 281, 2.93));
        testWarehouse4.Push(new Product("Daisy", 345, 79, 21.88));
        testWarehouse4.Push(new Product("Scilla", 456, 1, 2.69));
        testWarehouse4.Push(new Product("Marigold", 567, 28, 1.59));
        testWarehouse4.Push(new Product("Lavender", 678, 999, .56));
        testWarehouse4.Push(new Product("Dahlia", 789, 102, 1.99));
        testWarehouse4.Push(new Product("Tulip", 891, 340, 1.03));

        Assert.AreEqual(Program.Highest(testWarehouse), 1728.52);
        Assert.AreEqual(Program.Highest(testWarehouse1), 35020);
        Assert.AreEqual(Program.Highest(testWarehouse2), 153160);
        Assert.AreEqual(Program.Highest(testWarehouse3), 2959);
        Assert.AreEqual(Program.Highest(testWarehouse4), 18720);

        Assert.AreEqual(Program.Lowest(testWarehouse), 44.52);
        Assert.AreEqual(Program.Lowest(testWarehouse1), 44.52);
        Assert.AreEqual(Program.Lowest(testWarehouse2), 1.03);
        Assert.AreEqual(Program.Lowest(testWarehouse3), 3.09);
        Assert.AreEqual(Program.Lowest(testWarehouse4), 2.69);
    }
}

