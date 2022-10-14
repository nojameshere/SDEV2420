
namespace CH15PayrollWithProperties
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 15 Payroll with Properties by James Sales\n");

            Employees[] array = new Employees[4];
            array[0] = new Salary("James", "Sales", 123, 56);
            array[1] = new Hourly("Josh", "Beitler", 369, 36, 39);
            array[2] = new Hourly("Andrew", "Jackson", 1829, 11.72, 42);
            array[3] = new Salary("Neil", "Harris", 401, 45);
            foreach (Employees employee in array)
            {
                Console.WriteLine(employee.ToString());
            }
            Console.WriteLine("\nPress a key, any key, remember that key, I'm now doing to shuffle that key back into the deck, remember your key?");
            Console.WriteLine("IS THIS YOUR KEY?");
            Console.WriteLine("Oh... then press the key to continue");
            Console.ReadKey();
        }
    }
}