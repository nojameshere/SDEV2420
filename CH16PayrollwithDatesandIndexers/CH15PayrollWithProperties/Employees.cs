using System;
namespace CH15PayrollWithProperties
{
    public abstract class Employees
    {
        protected static int payMonth = 11;
        protected string first, last;
        protected Date hireDate;
        protected Date birthDate;
        protected int id;
        protected double wage;
        protected static decimal totalWage;
        public Employees(string first, string last, int idNumber, double wage, int hireMM, int hireDD, int hireYY, int birthMM, int birthDD, int birthYY)
        {
            First = first;
            Last = last;
            ID = idNumber;
            Wage = wage;
            hireDate = new Date(hireYY, hireMM, hireDD);
            birthDate = new Date(birthYY, birthMM, birthDD);

        }
        public override string ToString()
        {
            return $"Employee {this.ID}: {this.first} {this.last}";//return employee number and name.
        }
        public abstract decimal Earnings();
        public decimal TotalPay
        {
            get { return totalWage; }
        }
        public Date HireDate
        {
            get { return this.hireDate; }
        }
        public Date BirthDate
        {
            get { return this.birthDate; }
        }
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
        public void CheckBonus()
        {
            decimal payWithBonus;
            if (this.BirthDate["mon"] == payMonth && this.HireDate["mon"] == payMonth)
            {
                payWithBonus = Earnings() + 750;
                Console.WriteLine($"{ID}: weekly earnings: Birthday month, bonus $250, Anniversary, bonus $500, {payWithBonus:C2}");
                totalWage += payWithBonus;
            }
            else if (this.BirthDate["mon"] == payMonth)
            {
                payWithBonus = Earnings() + 250;
                Console.WriteLine($"{ID}: weekly earnings: Birthday month, bonus $250, {payWithBonus:C2}");
                totalWage += payWithBonus;
            }
            else if (this.HireDate["mon"] == payMonth)
            {
                payWithBonus = Earnings() + 500;
                Console.WriteLine($"{ID}: weekly earnings: Anniversary, bonus $500, {payWithBonus:C2}");
                totalWage += payWithBonus;
            }
            else
            {
                Console.WriteLine($"{ID}: weekly earnings: {Earnings():C2}");
            }
        }
    }
    public class Hourly : Employees
    {
        
        int hoursWorked;
        public Hourly(string first, string last, int idNumber, double wage, int hoursWorked, int hireMM, int hireDD, int hireYY, int birthMM, int birthDD, int birthYY)
            : base(first, last, idNumber, wage, hireMM, hireDD, hireYY, birthMM, birthDD, birthYY)
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
            return $"Employee {ID}: {First} {Last}, birthdate {birthDate.ToString()}, hired {hireDate.ToString()}, Hourly, wage {Wage:C2}, hours worked {Hours}";
        }
    }
    public class Salary : Employees
    {
        public Salary(string first, string last, int idNumber, double wage, int hireMM, int hireDD, int hireYY, int birthMM, int birthDD, int birthYY)
            : base(first, last, idNumber, wage, hireMM, hireDD, hireYY, birthMM, birthDD, birthYY)
        {

        }
        public override decimal Earnings()
        {
            decimal earnings = (decimal)wage * 80;
            return earnings;
        }
        public override string ToString()
        {
            return $"Employee {ID}: {First} {Last}, birthdate {birthDate.ToString()}, hired {hireDate.ToString()}, Salaried, {Wage * 2080:C2} annual";
        }
    }
}

