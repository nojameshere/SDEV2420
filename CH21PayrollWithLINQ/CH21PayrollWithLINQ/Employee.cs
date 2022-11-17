using System;
namespace PayrollWithLINQ
{
    public class Employee
    {
        protected string first, last;
        protected int id;
        protected double rate;
        public Employee(string fName, string lName, int empID, double hourlyRate)
        {
            First = fName;
            Last = lName;
            ID = empID;
            Rate = hourlyRate;
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
        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }
    }
}

