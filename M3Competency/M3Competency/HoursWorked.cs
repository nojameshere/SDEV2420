using System;
namespace M3Competency;

public class HoursWorked
{
    protected int empID;
    protected double monHours, tueHours, wedHours, thuHours, friHours;
    public HoursWorked(int empID, double mondayHours, double tuesdayHours, double wednesdayHours, double thursdayHours, double fridayHours)
    {
        EmpID = empID;
        MonHours = mondayHours;
        TueHours = tuesdayHours;
        WedHours = wednesdayHours;
        ThuHours = thursdayHours;
        FriHours = fridayHours;
    }
    public int EmpID
    {
        get { return empID; }
        set { empID = value; }
    }
    public double MonHours
    {
        get { return monHours; }
        set { monHours = value; }
    }
    public double TueHours
    {
        get { return tueHours; }
        set { tueHours = value; }
    }
    public double WedHours
    {
        get { return wedHours; }
        set { wedHours = value; }
    }
    public double ThuHours
    {
        get { return thuHours; }
        set { thuHours = value; }
    }
    public double FriHours
    {
        get { return friHours; }
        set { friHours = value; }
    }
}
