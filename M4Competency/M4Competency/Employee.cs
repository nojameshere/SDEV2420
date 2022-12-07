using System;
using System.Collections.Generic;
using System.Text;

namespace M4Competency
{
    class Employee
    {
        protected int empID, MM, DD, YYYY;
        protected string lName, fName, department;
        protected double rate;
        public Date hireDate;
        public Employee(int empID, string first, string last, double payRate, string deptAbbreviated, int hireMonth, int hireDay, int hireYear)
        {
            EmpID = empID;
            First = first;
            Last = last;
            Rate = payRate;
            Department = deptAbbreviated;
            hireDate = new Date(hireYear, hireMonth, hireDay);
        }
        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }
        public string Last
        {
            get { return lName; }
            set { lName = value; }
        }
        public string First
        {
            get { return fName; }
            set { fName = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }
    }
}
