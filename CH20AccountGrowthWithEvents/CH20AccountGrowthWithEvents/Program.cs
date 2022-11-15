using System.ComponentModel;

namespace AccountGrowth;

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Chapter 20 Account Growth with Events by James Sales\n");
        Console.Write("What is the startin balance? $");
        double balance = double.Parse(Console.ReadLine());
        Console.Write("What is the interest rate? ");
        int rate = int.Parse(Console.ReadLine());
        Console.Write("How many cycles to grow the account? ");
        int cycles = int.Parse(Console.ReadLine());
        Account account = new Account(balance, rate, cycles);
        //Events are here
        account.AccountHundred += EventMessage;
        account.AccountDoubled += EventMessage;
        //Events are above
        Console.WriteLine($"Account has balance of {account.CurrentBalance:C2}");
        for (int i = 0; i < account.numCycles; i++)
        {
            account.RunCycle();
            Console.WriteLine($"In cycle {i}, Account has a balance of {account.CurrentBalance:C2}");
        }
        Console.WriteLine($"Account has balance of {account.CurrentBalance:C2}");

        Console.WriteLine("\nPress an any key to continue");
        Console.ReadKey();
    }
    public static void EventMessage(string msg)
    {
        Console.WriteLine(msg);
    }
}