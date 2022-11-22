using System;
namespace M3Competency;

public class Employee
{
    protected int empID, MM, DD, YYYY;
    protected string name, department;
    protected double rate;
    public Date hireDate;
    public Employee(int empID, string first, string last, double payRate, string deptAbbreviated, int hireMonth, int hireDay, int hireYear)
    {
        EmpID = empID;
        Name = first + ' ' + last;
        Rate = payRate;
        Department = deptAbbreviated;
        hireDate = new Date(hireYear, hireMonth, hireDay);
    }
    public int EmpID
    {
        get { return empID; }
        set { empID = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
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


