using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M4Competency
{
    public partial class Form1 : Form
    {

        Employee[] employees =
           {
            new Employee(1234, "Ann",    "Dawson",   12.50, "HR", 3,16,2018),
            new Employee(4321, "David",  "Adams",    10.50, "IT", 4,20,2018),
            new Employee(3456, "Gary",   "Emerson",  10.00, "SA", 8,28,2016),
            new Employee(6543, "Ella",   "Grayson",  11.00, "HR", 10,15,2015),
            new Employee(7890, "Cathy",  "Brooks",   15.00, "IT", 1,15,2015),
            new Employee(9870, "Bob",    "Clarke",   15.00, "IT", 9,1,2018),
            new Employee(5561, "Mary",   "Stamp",    11.50, "SA", 7,6,2017),
            new Employee(6712, "Steve",  "Lamb",     13.50, "SA",5,20,2017),
            new Employee(2341, "Abby",   "Cooper",   12.50, "HR",3,6,2020),
            new Employee(3214, "Jane",   "Hansen",   12.25, "IT",7,22,2018),
            new Employee(4563, "Frank",  "Jones",    10.75, "SA",1,25,2016),
            new Employee(5436, "Harry",  "Martin",   14.00, "HR",10,14,2017),
            new Employee(8907, "Lee",    "Porter",   15.00, "IT",1,5,2015),
            new Employee(8709, "Peter",  "Clark",    13.25, "IT",4,15,2018),
            new Employee(5615, "James",  "Smith",    11.50, "SA",7,16,2019),
            new Employee(7126, "Laura",  "Thorn",    15.50, "SA",5,22,2016),
            new Employee(4123, "Sarah",  "Flagg",    11.50, "HR",9,7,2018),
            new Employee(1432, "John",   "Howard",   10.00, "IT",10,21,2017),
            new Employee(6345, "John",   "Wallace",  10.00, "SA",5,21,2016),
            new Employee(3654, "Greg",   "Masters",  11.00, "HR",10,10,2018),
            new Employee(1789, "Bob",    "Johnson",  15.00, "IT",1,27,2017),
            new Employee(1987, "Dan",    "Ferguson", 15.00, "IT",9,5,2016),
            new Employee(1556, "Sam",    "Ericson",  12.50, "SA",7,23,2018),
            new Employee(2671, "Chris",  "Daniels",  13.50, "SA",5,15,2016),
            new Employee(2134, "Evan",   "Harris",   12.50, "HR",3,4,2015),
            new Employee(3421, "Tom",    "Smith",    10.50, "IT",4,10,2017),
            new Employee(4356, "Ron",    "Greyson",  10.00, "SA",8,18,2018),
            new Employee(5643, "Fred",   "Jones",    11.00, "HR",10,3,2016),
            new Employee(8790, "Kevin",  "Carson",   15.00, "IT",1,24,2016),
            new Employee(8970, "Martha", "Rollins",  15.00, "IT",9,17,2017),
            new Employee(6561, "Phil",   "Spencer",  12.50, "SA",7,26,2016),
            new Employee(7612, "Rachel", "Walker",   13.50, "SA",5,2,2018)
        };
        HoursWorked[] hoursWorked =
        {
            new HoursWorked(1234, 8.0, 7.5, 7.5, 8.0, 8.0),
            new HoursWorked(4321, 6.5, 8.5, 7.5, 6.0, 6.0),
            new HoursWorked(3456, 6.0, 7.5, 6.5, 8.0, 7.0),
            new HoursWorked(6543, 8.0, 8.0, 8.0, 8.0, 8.0),
            new HoursWorked(7890, 8.5, 8.0, 8.0, 7.5, 7.0),
            new HoursWorked(9870, 9.0, 8.0, 7.0, 6.0, 8.0),
            new HoursWorked(5561, 7.0, 7.5, 7.5, 8.0, 7.5),
            new HoursWorked(6712, 8.0, 7.5, 8.5, 8.0, 8.0),
            new HoursWorked(2341, 8.0, 7.5, 7.5, 8.0, 8.0),
            new HoursWorked(3214, 6.5, 8.5, 7.5, 6.0, 6.0),
            new HoursWorked(4563, 6.0, 7.5, 6.5, 8.0, 7.0),
            new HoursWorked(5436, 8.0, 8.0, 8.0, 8.0, 8.0),
            new HoursWorked(8907, 8.5, 8.0, 8.0, 7.5, 7.0),
            new HoursWorked(8709, 9.0, 8.0, 7.0, 6.0, 8.0),
            new HoursWorked(5615, 7.0, 7.5, 7.5, 8.0, 7.5),
            new HoursWorked(7126, 8.0, 7.5, 8.5, 8.0, 8.0),
            new HoursWorked(4123, 8.0, 7.5, 7.5, 8.0, 8.0),
            new HoursWorked(1432, 6.5, 8.5, 7.5, 6.0, 6.0),
            new HoursWorked(6345, 6.0, 7.5, 6.5, 8.0, 7.0),
            new HoursWorked(3654, 8.0, 8.0, 8.0, 8.0, 8.0),
            new HoursWorked(1789, 8.5, 8.0, 8.0, 7.5, 7.0),
            new HoursWorked(1987, 9.0, 8.0, 7.0, 6.0, 8.0),
            new HoursWorked(1556, 7.0, 7.5, 7.5, 8.0, 7.5),
            new HoursWorked(2671, 8.0, 7.5, 8.5, 8.0, 8.0),
            new HoursWorked(2134, 8.0, 7.5, 7.5, 8.0, 8.0),
            new HoursWorked(3421, 6.5, 8.5, 7.5, 6.0, 6.0),
            new HoursWorked(4356, 6.0, 7.5, 6.5, 8.0, 7.0),
            new HoursWorked(5643, 8.0, 8.0, 8.0, 8.0, 8.0),
            new HoursWorked(8790, 8.5, 8.0, 8.0, 7.5, 7.0),
            new HoursWorked(8970, 9.0, 8.0, 7.0, 6.0, 8.0),
            new HoursWorked(6561, 7.0, 7.5, 7.5, 8.0, 7.5),
            new HoursWorked(7612, 8.0, 7.5, 8.5, 8.0, 8.0)
        };
        Department[] depts =
        {
            new Department("HR", "Human Resources"),
            new Department("IT", "Information Technology"),
            new Department("SA", "Sales")
        };
        public Form1()
        {
            InitializeComponent();
        }

        private async void calculateButton_Click(object sender, EventArgs e)
        {
            //Main button press sender
            payrollBox.Items.Clear();
            //To simulate the super long calculating time we're calling the fibonacci method with a value of 40
            Task<long> task = Task.Run(() => Fibonacci(40));
            await task;
            var sortedForDepartment = from employee in employees
                                      join hours in hoursWorked on employee.EmpID equals hours.EmpID
                                      orderby employee.Department
                                      select new
                                      {
                                          name = employee.First + " " + employee.Last,
                                          department = employee.Department,
                                          EmpID = employee.EmpID,
                                          Rate = employee.Rate,
                                          totalHours = hours.MonHours + hours.TueHours + hours.WedHours + hours.ThuHours + hours.FriHours
                                      };
            foreach (var employee in sortedForDepartment)
            {
                payrollBox.Items.Add($"{employee.EmpID}\t{employee.name}\t\ttotal hours {employee.totalHours}\t total pay {employee.totalHours * employee.Rate:C2}");
            }

        }

        private void byLastName_CheckedChanged(object sender, EventArgs e)
        {
            //List employees by last name
            empInfoBox.Items.Clear();
            var byLast = from employee in employees
                         orderby employee.Last
                         select employee;
            foreach (Employee employee in byLast)
            {
                empInfoBox.Items.Add($"{employee.EmpID}\t{employee.Last}, {employee.First}\t{employee.Department}");
            }
        }

        private void byDepartment_CheckedChanged(object sender, EventArgs e)
        {
            //List employees by department
            empInfoBox.Items.Clear();
            var byDept = from employee in employees
                         orderby employee.Department
                         select employee;
            foreach (Employee employee in byDept)
            {
                empInfoBox.Items.Add($"{employee.EmpID}\t{employee.Last}, {employee.First}\t{employee.Department}");
            }
        }

        private void byEmployeeID_CheckedChanged(object sender, EventArgs e)
        {
            //List employees by empID
            empInfoBox.Items.Clear();
            var byID = from employee in employees
                       orderby employee.EmpID
                       select employee;
            foreach (Employee employee in byID)
            {
                empInfoBox.Items.Add($"{employee.EmpID}\t{employee.Last}, {employee.First}\t{employee.Department}");
            }
        }

        private void byHireDate_CheckedChanged(object sender, EventArgs e)
        {
            empInfoBox.Items.Clear();
            var byHireDate = from employee in employees
                             orderby employee.hireDate.Month, employee.hireDate.Day
                             select employee;
            foreach (Employee employee in byHireDate)
            {
                empInfoBox.Items.Add($"{employee.EmpID}\t{employee.Last}, {employee.First}\t{employee.Department}\t{employee.hireDate}");
            }
        }
        public static long Fibonacci(long n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
