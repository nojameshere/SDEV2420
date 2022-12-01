using System;
namespace M3Competency;

public class Department
{
    protected string departmentABV, departmentName;
    public Department(string departmentAbbreviation, string departmentName)
    {
        DepartmentABV = departmentAbbreviation;
        DepartmentName = departmentName;
    }
    public string DepartmentABV
    {
        get { return departmentABV; }
        set { departmentABV = value; }
    }
    public string DepartmentName
    {
        get { return departmentName; }
        set { departmentName = value; }
    }
}


