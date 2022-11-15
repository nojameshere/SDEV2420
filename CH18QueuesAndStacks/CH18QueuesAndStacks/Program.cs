using System;
using System.Collections.Generic;
namespace CH18QueuesAndStacks;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chapter 18 Queues and Stacks by James Sales");

        //Queue time
        Queue<string> names = new Queue<string>();

        //to fill queue
        Console.WriteLine("\nQueue");
        foreach (string name in new string[] { "Cory", "Mario", "James", "Michael" })
        {
            names.Enqueue(name);
            Console.WriteLine($"Adding {name} to the queue");
        }
        //Iterate queue
        Console.WriteLine("\nThe queue contains these names");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        //Empty the queue
        Console.WriteLine("\nRemoving names from the queue");
        while (names.Count > 0)
        {
            string name = names.Dequeue();
            Console.WriteLine($"Just removed {name} from the queue");
        }


        //Stack time!
        Stack<string> namesStack = new Stack<string>();
        Console.WriteLine("\n\nStack");
        //Stacking names
        foreach (string name in new string[] { "Cory", "Mario", "James", "Michael" })
        {
            namesStack.Push(name);
            Console.WriteLine($"Adding {name} to the stack");
        }

        Console.WriteLine("\nThe stack contains these names");
        //iterate through stack
        foreach (string name in namesStack)
        {
            Console.WriteLine(name);
        }
        //removing items from stack
        Console.WriteLine("\nRemoving names from stack");
        while (namesStack.Count > 0)
        {
            string name = namesStack.Pop();
            Console.WriteLine($"Just removed {name} from the stack");
        }
        //Program pause statement
        Console.WriteLine("Press a key to continue");
        Console.ReadKey();
    }
}