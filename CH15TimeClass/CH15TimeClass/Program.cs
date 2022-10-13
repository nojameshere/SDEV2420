using CH15TimeClass;

class Program
{
    static void Main(string[] args)
    {
        //stuff goes here
        Console.WriteLine("Chapter 15 Time Class by James Sales\n");

        Console.WriteLine("Part 1: Creating objects with 3 valid parameters then changing one value to invalid");

        Time time1 = new Time(9, 10, 58);
        Console.WriteLine(time1.ToString());
        time1.Hours = 99;
        Console.WriteLine(time1.ToString());
        Time time2 = new Time(14, 30, 17);
        Console.WriteLine(time2.ToString());
        time2.Minutes = 130;
        Console.WriteLine(time2.ToString());
        Time time3 = new Time(20, 24, 40);
        Console.WriteLine(time3.ToString());
        time3.Seconds = 123;
        Console.WriteLine(time3.ToString());

        Console.WriteLine("\nInstantiating Invalid Objects");

        Time time4 = new Time(25, 15, 30);
        Console.WriteLine(time4.ToString());
        Time time5 = new Time(18, 105, 45);
        Console.WriteLine(time5.ToString());
        Time time6 = new Time(11, 5, 99);
        Console.WriteLine(time6.ToString());
        Time time7 = new Time(100, 100, 100);
        Console.WriteLine(time7.ToString());
        time7.Seconds = 34;
        time7.Minutes = 12;
        time7.Hours = 5;
        Console.WriteLine(time7.ToString());

        Console.WriteLine("\nPart 2: Instantiating Incomplete Objects using THIS constructor");

        Time time8 = new Time(11);
        Console.WriteLine(time8.ToString());
        Time time9 = new Time(5, 25);
        Console.WriteLine(time9.ToString());
        Time time10 = new Time(30);
        Console.WriteLine(time10.ToString());
        time10.Hours = 2;
        Console.WriteLine(time10.ToString());
        Time time11 = new Time(48, 120);
        Console.WriteLine(time11.ToString());
        time11.Hours = 4;
        time11.Minutes = 45;
        Console.WriteLine(time11.ToString());

        //end console program statement
        Console.WriteLine("\nPress any key to continue");
        Console.ReadKey();
    }
}