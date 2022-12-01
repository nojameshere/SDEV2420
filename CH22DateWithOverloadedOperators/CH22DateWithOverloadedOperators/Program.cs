using System.Collections;

namespace OverloadedDateClass;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chapter 22 Date with Overloaded Operators");

        Console.WriteLine("\nStart with a goog date");
        Console.Write("Enter a month number: ");
        int enteredMonth = int.Parse(Console.ReadLine());
        Console.Write("Enter a day number: ");
        int enteredDay = int.Parse(Console.ReadLine());
        Console.Write("Enter a year: ");
        int enteredYear = int.Parse(Console.ReadLine());
        Date date = new Date(enteredYear, enteredMonth, enteredDay);
        Console.WriteLine($"The date is {date.ToString()}");
        //Date object created.
        Console.Write("How many days to add using operator overload? ");
        int daysAdded = int.Parse(Console.ReadLine());
        Console.WriteLine($"Result of adding {daysAdded} to date: {date + daysAdded}");
        Console.Write("How many days to add using compunt assignment? ");
        daysAdded = int.Parse(Console.ReadLine());
        Console.WriteLine($"Using compound add, result of adding {daysAdded} is {date += daysAdded}");

        //Program pause statement
        Console.WriteLine("\nPress any key to close program");
        Console.ReadKey();
    }
}