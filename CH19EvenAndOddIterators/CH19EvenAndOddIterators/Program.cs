namespace CH19EvenAndOddIterators;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chapter 19 Even and Odd Iterators by James Sales");

        Stack<int> theStack = new Stack<int>();
        for (int number = 0; number <= 10; number++)
        {
            theStack.Push(number);
        }
        Console.WriteLine("Display contents of stack");
        foreach (int number in theStack.TopToBottom)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine("\nDisplay contents using named iterator TopToBottom");
        foreach (int number in theStack.TopToBottom)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine("\nDisplay contents using named iterator BottomToTop");
        foreach (int number in theStack.BottomToTop)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine("\nDisplay contents using named iterator Evens");
        foreach (int number in theStack.Evens)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine("\nDisplay contents using named iterator Odds");
        foreach (int number in theStack.Odds)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine("\nPress a key to continue");
        Console.ReadKey();
    }
}