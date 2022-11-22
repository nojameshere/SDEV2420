using System.Collections;

namespace M3Competency;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Module 3 Competency, Payroll with LINQ and Operator Overloading by James Sales");

        Employee[] employees =
        {
            new Employee(1234, "James", "Sales",  21.50, "IT", 11, 04, 2017),
            new Employee(4321, "Ann", "Adams",    10.50, "HR", 4, 20, 2018),
            new Employee(3456, "Ella", "Emerson", 10.00, "SA", 8, 28, 2016),
            new Employee(6543, "Gary", "Gray",    11.00, "HR", 10, 15, 2015),
            new Employee(7890, "Bob", "Brooks",   15.00, "IT", 1, 15, 2015),
            new Employee(9870, "Cathy", "Clarke", 15.00, "IT", 9, 1, 2018),
            new Employee(5561, "Sam", "Stamp",     9.50, "SA", 7, 6, 2017),
            new Employee(6712, "Mary", "Lamb",    13.50, "SA", 5, 20, 2017)
        };
        HoursWorked[] hoursWorked =
        {
            new HoursWorked(1234, 0.0, 10,  10,  10,  10),
            new HoursWorked(4321, 6.5, 8.5, 7.5, 6.0, 6.0),
            new HoursWorked(3456, 6.0, 7.5, 6.5, 8.0, 7.0),
            new HoursWorked(6543, 8.0, 8.0, 8.0, 8.0, 8.0),
            new HoursWorked(7890, 8.5, 8.0, 8.0, 7.5, 7.0),
            new HoursWorked(9870, 9.0, 8.0, 7.0, 6.0, 8.0),
            new HoursWorked(5561, 7.0, 7.5, 7.5, 8.0, 7.5),
            new HoursWorked(6712, 8.0, 7.5, 8.5, 8.0, 8.0)
        };
        Department[] departments =
        {
            new Department("HR", "Human Resources"),
            new Department("IT", "Information Technology"),
            new Department("SA", "Sales")
        };
        Console.WriteLine("\nCount Employees and Departments");

        Console.WriteLine($"\nThere are {employees.Count()} employees");
        Console.WriteLine($"There are {departments.Count()} departments");

        //LINQ for employees by department
        Console.WriteLine("\nList Employees by department");
        var byDept = from employee in employees
                     join department in departments on employee.Department equals department.DepartmentABV
                     orderby employee.Department
                     select new
                     {
                         Name = employee.Name,
                         EmpID = employee.EmpID,
                         EmpDepartment = department.DepartmentName
                     };

        foreach (var employee in byDept)
        {
            Console.WriteLine($"{employee.EmpID} {employee.Name}, from {employee.EmpDepartment}");
        }

        //List for employees with hire dates AND probation dates
        Console.WriteLine("\nEmployees with Hire and Probation end dates");
        foreach (Employee employee in employees)
        {
            Console.WriteLine($"{employee.EmpID} hired on {employee.hireDate}, probation done {employee.hireDate + 90}");
        }

        //LINQ grouped employees by department
        Console.WriteLine("\nEmployees grouped by department");
        var byDepartment = from department in departments
                           join employee in employees on department.DepartmentABV equals employee.Department into gj
                           select new
                           {
                               DepartmentName = department.DepartmentABV,
                               departments = gj
                           };
        foreach (var item in byDepartment) 
        {
            Console.WriteLine($"\nDept = {item.DepartmentName}");
            foreach (var group in item.departments)
            {
                Console.WriteLine($"{group.EmpID} {group.Name}");
            }
        }

        //List employees by department and display their total pay
        Console.WriteLine("\nDisplay employees total hours and total pay, sorted by department");
        var sortedForDepartment = from employee in employees
                                  join hours in hoursWorked on employee.EmpID equals hours.EmpID
                                  orderby employee.Department
                                  select new
                                  {
                                      department = employee.Department,
                                      EmpID = employee.EmpID,
                                      Rate = employee.Rate,
                                      totalHours = hours.MonHours + hours.TueHours + hours.WedHours + hours.ThuHours + hours.FriHours
                                  };

        foreach (var item in sortedForDepartment)
        {
            Console.WriteLine($"{item.department}: {item.EmpID}, rate {item.Rate:C2}, total hours {item.totalHours}, total pay {item.Rate * item.totalHours:C2}");
        }
        var departmentTotalPay = from department in departments
                                 join item in sortedForDepartment on department.DepartmentABV equals item.department into gj
                                 select new
                                 {
                                     departmentName = department.DepartmentABV,
                                     groupJoin = gj
                                 };

        //Sort total pay for each department
        double grandTotal = 0;
        foreach (var item in departmentTotalPay)
        {
            double departmentTotal = 0;
            Console.WriteLine($"\nDepartment: {item.departmentName}");
            foreach (var thing in item.groupJoin)
            {
                double totalPay = thing.totalHours * thing.Rate;
                Console.WriteLine($"{thing.EmpID}, total pay {totalPay:C2}");
                departmentTotal += totalPay;
                grandTotal += totalPay;
            }
            Console.WriteLine($"Total pay for department: {departmentTotal:C2}");
        }
        Console.WriteLine($"\nTotal pay for all departments: {grandTotal:C2}");

        //Program pause statement
        Console.WriteLine("\nPress a key to contine");
        Console.ReadKey();
    }
}