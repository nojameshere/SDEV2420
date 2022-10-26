namespace CH17GenericMinMax;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chapter 17 Generic Min Max by James Sales\n");

        int[] intArray = { 23, 9, 0, 210, 55, 39, 80, 31, 30 };
        double[] doubleArray = { 29.6, 20.1, 11.2, 90.6, 11.3, 66.4 };
        string[] stringArray = { "toaster", "oven", "fridge", "freezer", "microwave" };

        //Display arrays
        Console.Write("Array intArray contains: ");
        DisplayArray(intArray);
        Console.Write("Array doubleArray contains: ");
        DisplayArray(doubleArray);
        Console.Write("Array stringArray contains: ");
        DisplayArray(stringArray);

        Console.WriteLine($"\nMinimum for intArray is: {Minimum<int>(intArray)}");
        Console.WriteLine($"Maximum for intArray is: {Maximum<int>(intArray)}");

        Console.WriteLine($"\nMinimum for doubleArray is: {Minimum<double>(doubleArray)}");
        Console.WriteLine($"Maximum for doubleArray is: {Maximum<double>(doubleArray)}");

        Console.WriteLine($"\nMinimum for stringArray is: {Minimum<string>(stringArray)}");
        Console.WriteLine($"Maximum for stringArray is: {Maximum<string>(stringArray)}");

        //program pause statement
        Console.WriteLine("\nPress a key to continue");
        Console.ReadKey();
    }
    public static T Maximum<T>(T[] inputArray) where T : IComparable<T>
    {
        var max = inputArray[0];
        foreach (T item in inputArray)
        {
            if (item.CompareTo(max) > 0){
                max = item;
            }
        }
        return max;
    }
    public static T Minimum<T>(T[] inputArray) where T : IComparable<T>
    {
        var min = inputArray[0];
        foreach (T item in inputArray)
        {
            if (item.CompareTo(min) < 0)
            {
                min = item;
            }
        }
        return min;
    }
    public static void DisplayArray(int[] inputArray)
    {
        foreach (var element in inputArray)
        {
            Console.Write($"{element} ");
        }

        Console.WriteLine();
    }

    //output double array                                 
    public static void DisplayArray(double[] inputArray)
    {
        foreach (var element in inputArray)
        {
            Console.Write($"{element} ");
        }

        Console.WriteLine();
    }

    //output string array                                 
    public static void DisplayArray(string[] inputArray)
    {
        foreach (var element in inputArray)
        {
            Console.Write($"{element} ");
        }

        Console.WriteLine();
    }
}