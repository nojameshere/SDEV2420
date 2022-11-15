using System;
using System.Collections.Generic;

namespace CH18SortedLists;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chapter 18 Sorted Lists by James Sales");
        SortedList<int, string> products = new SortedList<int, string>();

        bool cont = true;
        while (cont)
        {
            Console.Write("\nEnter product ID (integer): ");
            int productID = int.Parse(Console.ReadLine());
            Console.Write("Enter product name: ");
            string product = Console.ReadLine();
            //Add product to list
            products.Add(productID, product);

            Console.WriteLine("\nList contents");
            foreach (KeyValuePair<int, string> element in products)
            {
                int ID = element.Key;
                string name = element.Value;
                Console.WriteLine($"{ID} {name}");
            }
            Console.Write("\nAny more to add? Y/N ");
            if (Console.ReadLine().ToLower() == "n")
            {
                cont = false;
            }
        }
        //Program pause statement
        Console.WriteLine("Press a key to continue");
        Console.ReadKey();
    }
}