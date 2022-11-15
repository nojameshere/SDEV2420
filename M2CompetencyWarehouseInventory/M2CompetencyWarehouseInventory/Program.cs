using System.Collections;
namespace TotallyLegitNamespace;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Module 2 Competency Warehouse Inventory by James Sales\n");

        double totalWarehouseValue = 0;
        //Creating and populating new warehouse array
        Warehouse<Product> warehouse = new Warehouse<Product>();
        warehouse.Push(new Product("Crocus", 123, 248, 4.68));
        warehouse.Push(new Product("Poppy", 234, 281, 2.93));
        warehouse.Push(new Product("Daisy", 345, 79, 21.88));
        warehouse.Push(new Product("Scilla", 456, 110, 2.69));
        warehouse.Push(new Product("Marigold", 567, 28, 1.59));
        warehouse.Push(new Product("Lavender", 678, 999, .56));
        warehouse.Push(new Product("Dahlia", 789, 102, 1.99));
        warehouse.Push(new Product("Tulip", 891, 340, 1.03));
        //List all of the products.
        foreach (Product product in warehouse)
        {
            Console.WriteLine($"{product.ID} {product.Name}: \tprice {product.Price:C2}, \tquantity {product.Quantity} \tItem Value: {product.TotalValue:C2}");
            totalWarehouseValue += product.TotalValue;
        }
        Console.WriteLine($"\nTotal Value in Warehouse: {totalWarehouseValue:C2}");
        //Compare item values to see what is rated highest and which is lowest
        Highest(warehouse);
        Lowest(warehouse);
        //Progarm pauses here because heaven forbid we want to be able to look at the console output by default.
        Console.WriteLine("\nPress key to continue please and thank you");
        Console.ReadKey();
    }
    public static double Highest(Warehouse<Product> warehouse)
    {
        var enumerator = warehouse.GetEnumerator();
        Product highestProduct = new Product("t", 1, 1, -1);
        while (enumerator.MoveNext())
        {
            var current = enumerator.Current;
            if (current.CompareTo(highestProduct) == 1)
            {
                highestProduct = current;
            }
        }
        
        Console.WriteLine($"\nItem with largest value: {highestProduct.ID} {highestProduct.Name}: \tprice {highestProduct.Price:C2}, \tquantity {highestProduct.Quantity}");
        return highestProduct.TotalValue;
    }
    public static double Lowest(Warehouse<Product> warehouse)
    {
        var enumerator = warehouse.GetEnumerator();
        Product lowestProduct = new Product("t", 1, 1, Int32.MaxValue);
        while (enumerator.MoveNext())
        {
            var current = enumerator.Current;
            if (current.CompareTo(lowestProduct) == -1)
            {
                lowestProduct = current;
            }
        }
        
        Console.WriteLine($"\nItem with smallest value: {lowestProduct.ID} {lowestProduct.Name}: \tprice {lowestProduct.Price:C2}, \tquantity {lowestProduct.Quantity}");
        return lowestProduct.TotalValue;
    }
}