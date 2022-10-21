
namespace CH15PayrollWithProperties
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 15 Payroll with Properties by James Sales\n");
            //Original code with added birthdates and hire dates
            Employees[] array = new Employees[6];
            array[0] = new Salary("James", "Sales", 123, 56, 1, 30, 2006, 11, 4, 1997);
            array[1] = new Hourly("Josh", "Beitler", 369, 36, 39, 5, 4, 2008, 4, 16, 1998);
            array[2] = new Hourly("Andrew", "Jackson", 777, 11.72, 42, 11, 1, 1829, 3, 15, 1767);
            array[3] = new Salary("Neil", "Harris", 401, 45, 10, 31, 1979, 7, 23, 1800);
            array[4] = new Salary("Marlon", "Brando", 122, 35.9, 11, 11, 2011, 11, 14, 1966);
            array[5] = new Hourly("Tyler", "Jones", 918, 15, 60, 11, 5, 2001, 6, 1, 1999);//This person was hired at the age of 2...
            foreach (Employees employee in array)
            {
                Console.WriteLine(employee.ToString());
            }
            //Printing specific data outlined in the assignment
            Console.WriteLine();
            foreach (Employees employee in array)
            {
                Console.WriteLine($"{employee.ID}: Birth month {employee.BirthDate["mon"]}, hire month/year {employee.HireDate["mon"]}/{employee.HireDate["yr"]}");
            }
            //Printing all employees with bonuses (bonus month is 11)
            Console.WriteLine();
            foreach (Employees employee in array)
            {
                employee.CheckBonus();
            }
            Console.WriteLine($"\nTotal Pay: {array[0].TotalPay:C2}");

            Console.WriteLine("\nPress a key");
            Console.ReadKey();
        }
    }
}