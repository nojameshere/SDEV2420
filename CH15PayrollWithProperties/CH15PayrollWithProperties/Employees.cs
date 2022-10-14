using System;
namespace CH15PayrollWithProperties
{
    public abstract class Employees
    {
        protected string first, last;
        protected int id;
        protected double wage;
        protected static double totalWage;
        public Employees(string first, string last, int idNumber, double wage)
        {
            First = first;
            Last = last;
            ID = idNumber;
            Wage = wage;

        }
        public override string ToString()
        {
            return $"Employee {this.ID}: {this.first} {this.last}";//return employee number and name.
        }
        public abstract decimal Earnings();
        public string First
        {
            get { return first; }
            set { first = value; }
        }
        public string Last
        {
            get { return last; }
            set { last = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public double Wage
        {
            get { return this.wage; }
            set { wage = value; }
        }
    }
    public class Hourly : Employees
    {
        
        int hoursWorked;
        public Hourly(string first, string last, int idNumber, double wage, int hoursWorked)
            : base(first, last, idNumber, wage)
        {
            Hours = hoursWorked;
        }
        
        public int Hours
        {
            get { return this.hoursWorked; }
            set { hoursWorked = value; }
        }
        public override decimal Earnings()
        {
            decimal earnings = (decimal)wage * hoursWorked;
            return earnings;
        }
        public override string ToString()
        {
            return $"Employee {ID}: {First} {Last}, hourly wage {Wage:n2}, hours worked {Hours}";
        }
    }
    public class Salary : Employees
    {
        public Salary(string first, string last, int idNumber, double wage, int hoursWorked)
            : base(first, last, idNumber, wage)
        {

        }
        public override decimal Earnings()
        {
            decimal earnings = (decimal)wage * 2080;
            return earnings;
        }
        public override string ToString()
        {
            return $"Employee {ID}: {First} {Last}, Salaried, {Wage:n2} annual";
        }
    }
}

