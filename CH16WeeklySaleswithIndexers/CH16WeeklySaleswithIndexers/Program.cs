namespace CH16WeeklySaleswithIndexers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //stuff goes here
            bool cont = true;
            Console.WriteLine("Chapter 16 Weekly Sales with Indexers");

            DailySales sales = new DailySales();

            while (cont)
            {
                string dayInput;
                double salesInput;
                Console.Write("\nPlease enter day: ");
                dayInput = Console.ReadLine().ToLower();
                dayInput = char.ToUpper(dayInput[0]) + dayInput.Substring(1);
                Console.Write("Please enter sales: $ ");
                salesInput = double.Parse(Console.ReadLine());
                //Logic for adding sales to total in DailySales object.
                sales[dayInput] = salesInput; //This uses the indexer for day of week and users the setter to set the value
                //Its a little confusing but I really like how the logic works out, Its pretty cool

                Console.Write("Is there more? (Y/N) ");
                if (Console.ReadLine().ToLower() == "n")
                {
                    cont = false;
                    sales.Display();
                }

                //Check if user has changes
                if (!cont)
                {
                    Console.Write("\nDo you have any changes you need to make? (y/n)");
                    if(Console.ReadLine().ToLower() != "n")
                    {
                        cont = true;
                    }
                }
            }
            sales.Display();
            sales.CalcTotal();
            Console.WriteLine($"Total Sales: {sales.Total:C2}");

            Console.WriteLine("\nIf you're done, press the 'g' key");
            Console.ReadKey();
        }
    }
}