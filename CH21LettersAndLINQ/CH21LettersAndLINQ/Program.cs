namespace LettersAndLINQ;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chapter 21 Letters and LINQ by James Sales");
        char[] charArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char[] generatedArray = new char[26];
        Random rnd = new Random();
        for(int i = 0; i < 26; i++)
        {
            int randomIndex = rnd.Next(0, 25);
            generatedArray[i] = charArray[randomIndex];
        }
        Console.WriteLine(generatedArray);
        //Program pause statement
        Console.WriteLine("\nPress any key to continue");
        Console.ReadKey();
    }
}