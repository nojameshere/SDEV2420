using System.Security.Cryptography;

namespace DiceRolls;

public class DiceRolls
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chapter 24 Rolling Dice with Async Await by James Sales");

        doWork();



        Console.WriteLine("\nInside DoWork, does it wait for the tasks to complete?");
        Console.WriteLine("Does this wait to print after the DoWork method is called?");
        Console.WriteLine("\nAppuyez sur n'importe quelle touche pour continuer");
        Console.ReadKey();
    }
    private async static void doWork()
    {
        Console.Write("\nHow many rolls? ");
        var rolls = int.Parse(Console.ReadLine());
        Task task = Task.Run(() => rollDice(rolls));
        Task task2 = Task.Run(() => rollDice(rolls * 10));
        Task task3 = Task.Run(() => rollDice(rolls * 100));
        await Task.WhenAll(task, task2, task3);
    }
    public static void rollDice(int rolls)
    {
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
        Console.WriteLine($"Total number of rolls: {rolls:N0}\n");
    }
}