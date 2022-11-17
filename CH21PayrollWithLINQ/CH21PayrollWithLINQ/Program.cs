using System.Collections;
namespace PayrollWithLINQ;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chapter 21 Payroll with LINQ by James Sales");

        //Create 8 Employee() objects
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee("James", "Sales", 123, 21.99));
        employees.Add(new Employee("Josh", "Beitler",580 , 29.44));
        employees.Add(new Employee("Corey", "Coleman", 270, 30.06));
        employees.Add(new Employee("Jamie", "Lewis", 117, 7.25));
        employees.Add(new Employee("Cheryl", "Walker", 691, 15));
        employees.Add(new Employee("Lucy", "Meyers", 238, 46.25));
        employees.Add(new Employee("Millie", "Melton", 983, 11.72));
        employees.Add(new Employee("Michael", "Sebaske", 402, 22.90));

        //Create 8 HoursWorked() objects matching IDs with the Employee() objects
        List<HoursWorked> hoursWorked = new List<HoursWorked>();
        hoursWorked.Add(new HoursWorked(123, 0, 10, 11, 9, 10));
        hoursWorked.Add(new HoursWorked(580, 12, 5, 5, 8, 10));
        hoursWorked.Add(new HoursWorked(270, 1, 2, 3, 4, 5));
        hoursWorked.Add(new HoursWorked(117, 8, 8, 8, 8, 8));
        hoursWorked.Add(new HoursWorked(691, 0, 0, 0, 5, 7));
        hoursWorked.Add(new HoursWorked(238, 4, 3, 8, 9, 2));
        hoursWorked.Add(new HoursWorked(983, 6, 6, 6, 7, 9));
        hoursWorked.Add(new HoursWorked(402, 1, 1, 1, 16, 1));

        Console.WriteLine("\nDisplay employees sorted by hourly rate descending");
        var orderByRateDescending = from e in employees orderby e.Rate descending select e;
        foreach(Employee employee in orderByRateDescending)
        {
            Console.WriteLine($"{employee.ID} {employee.First} {employee.Last}, {employee.Rate:C2}");
        }
        //Next display employees sorted descending by total hours worked.
        Console.WriteLine("\nDisplay employees sorted by total hours worked");
        var query =
            from e in employees
            join hours in hoursWorked on e.ID equals hours.ID
            orderby hours.TotalHoursWorked descending
            select new
            {
                FullName = e.First + " " + e.Last,
                HourlyRate = e.Rate,
                EmpID = e.ID,
                HoursWorked = hours.TotalHoursWorked
            };

        foreach(var item in query)
        {
            Console.WriteLine($"{item.EmpID} {item.FullName}, rate {item.HourlyRate:C2}, worked {item.HoursWorked} hours");
        }
        //Next display employees' total hours AND total pay.
        Console.WriteLine("\nDisplay employees total hours and total pay");
        query = from item in query
                orderby item.EmpID
                select item;
        foreach(var item in query)
        {
            Console.WriteLine($"{item.EmpID}, rate {item.HourlyRate:C2}: total hours {item.HoursWorked}, total pay {item.HourlyRate * item.HoursWorked:C2}");
        }
        //var conjoinedTriangelsOfSuccess = employees.Join(
        //                                    hoursWorked,
        //                                    employees => employees.ID,
        //                                    hoursWorked => hoursWorked.ID,
        //                                    (employees, hoursWorked) => new
        //                                    {

        //                                    }
        
        

        Console.WriteLine("\nPress any key to unpause the program and close it.  .  .");
        Console.ReadKey();
    }
}