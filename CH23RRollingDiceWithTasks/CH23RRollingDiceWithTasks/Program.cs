using System.Security.Cryptography;

namespace DiceRolls;

public class DiceRolls
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chapter 23 Rolling Dice with Tasks by James Sales");

        Console.Write("\nHow many rolls? ");
        int numberOfRolls = int.Parse(Console.ReadLine());
        //DoWork(numberOfRolls);
        //DoWork(1000000);
        //DoWork(10000000);
        Task runDoWork = Task.Run(() => DoWork(numberOfRolls));
        Task runDoWork2 = Task.Run(() => DoWork(1000000));
        Task runDoWork3 = Task.Run(() => DoWork(10000000));

        Console.WriteLine("\nInside DoWork, does it wait for the tasks to complete?");
        Console.WriteLine("Does this wait to print after the DoWork method is called?");
        Console.WriteLine("\nAppuyez sur n'importe quelle touche pour continuer");
        Console.ReadKey();
    }
    public static void DoWork(int rolls)
    {
        Console.WriteLine();
        Random rng = new Random();
        int[] rollCounts = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        for (int i = 0; i < rolls; i++)
        {
            int r1 = rng.Next(1, 7);
            int r2 = rng.Next(1, 7);
            rollCounts[r1 + r2 - 1]++;
        }
        int iterator = 1;
        do
        {
            Console.WriteLine($"Value {iterator + 1} rolled {rollCounts[iterator]:N0} times");
            iterator++;
        }
        while (iterator < 12);
        Console.WriteLine($"Total number of rolls: {rolls:N0}");
    }
}