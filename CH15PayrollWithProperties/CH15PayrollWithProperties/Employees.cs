using System;
namespace CH15PayrollWithProperties
{
    public abstract class Employees
    {
        string first, last;
        int ID;
        public Employees(string first, string last, int ID)
        {
            this.first = first;
            this.last = last;
            this.ID = ID;
        }
        public override string ToString()
        {
            return base.ToString();//return employee number and name.
        }
        public abstract decimal Earnings();
    }
}

