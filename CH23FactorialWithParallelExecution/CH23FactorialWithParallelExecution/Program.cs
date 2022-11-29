


namespace Factorials;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chapter 23 Factorial with Parallel Execution by James Sales");
        //Console.WriteLine("\nInvoke 3 sequential methods");
        //CalcFirst();
        //CalcSecond();
        //CalcThird();
        Console.WriteLine("\nInvode 3 parallel methods");

        Parallel.Invoke(() =>
        {
            CalcFirst();
            CalcSecond();
            CalcThird();
        });

        Console.WriteLine("\nPress a key to continue");
        Console.ReadKey();
    }
    public static void Factorial(int number)
    {
        long result = 1;
        for (int k = number; k > 1; k--)
        {
            result *= k;
        }
        Console.WriteLine($"\nInside Factorial method, Factorial of {number} is {result:N}");
    }
    public static void CalcFirst()
    {
        Console.WriteLine("\nEntered CalcFirst");
        Factorial(10);
        Console.WriteLine("\nInside Calcfirst, factorial of 10 in complete");
    }
    public static void CalcSecond()
    {
        Console.WriteLine("\nEntered CalcSecond");
        Factorial(12);
        Console.WriteLine("\nInside CalcSecond, factorial of 12 in complete");
    }
    public static void CalcThird()
    {
        Console.WriteLine("\nEntered CalcThird");
        Factorial(20);
        Console.WriteLine("\nInside CalcThird, factorial of 20 in complete");
    }
}