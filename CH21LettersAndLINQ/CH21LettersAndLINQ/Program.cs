using System.Collections;
namespace LettersAndLINQ;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chapter 21 Letters and LINQ by James Sales");
        char[] charArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        List<char> generatedArray = new List<char>();
        Random rnd = new Random();
        for(int i = 0; i < 30; i++)
        {
            int randomIndex = rnd.Next(0, 25);
            generatedArray.Add(charArray[randomIndex]);
        }
        Console.WriteLine("\nGenerated List:");
        foreach(char letter in generatedArray)
        {
            Console.Write($"{letter} ");
        }
        Console.WriteLine();
        //Order alphabetically
        var orderByResult = from character in generatedArray
                            orderby character
                            select character;
        Console.WriteLine("\nAscending Order: ");
        foreach (char letter in orderByResult)
        {
            Console.Write($"{letter} ");
        }
        Console.WriteLine();
        //Remove duplicates
        var distinctAlphabetically = orderByResult.Distinct();
        Console.WriteLine("\nAscending Order, without duplicates: ");
        foreach (char letter in distinctAlphabetically)
        {
            Console.Write($"{letter} ");
        }
        Console.WriteLine();
        //Order reverse alphabetically
        var orderByDescendingResult = from character in generatedArray
                                      orderby character descending
                                      select character;
        Console.WriteLine("\nDescending Order: ");
        foreach (char letter in orderByDescendingResult)
        {
            Console.Write($"{letter} ");
        }
        Console.WriteLine();
        //Remove duplicates for reverse alphabetically
        var distinctReverseAlphabetically = orderByDescendingResult.Distinct();
        Console.WriteLine("\nDescending Order, without duplicates: ");
        foreach (char letter in distinctReverseAlphabetically)
        {
            Console.Write($"{letter} ");
        }
        Console.WriteLine();
        Console.WriteLine($"\nNumber of unique letters: {distinctAlphabetically.Count()}");
        //Program pause statement
        Console.WriteLine("\nPress any key to continue");
        Console.ReadKey();
    }
}