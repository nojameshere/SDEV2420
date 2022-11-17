using System;
namespace PayrollWithLINQ
{
    public class HoursWorked
    {
        protected int id;
        protected double monday, tuesday, wednesday, thursday, friday, totalHours;
        public HoursWorked(int empID, double mondayHours, double tuesdayHours, double wednesdayHours, double thursdayHours, double fridayHours)
        {
            ID = empID;
            MondayHours = mondayHours;
            TuesdayHours = tuesdayHours;
            WednesdayHours = wednesdayHours;
            ThursdayHours = thursdayHours;
            FridayHours = fridayHours;
            TotalHoursWorked = MondayHours + TuesdayHours + WednesdayHours + ThursdayHours + FridayHours;
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public double MondayHours
        {
            get { return monday; }
            set { monday = value; }
        }
        public double TuesdayHours
        {
            get { return tuesday; }
            set { tuesday = value; }
        }
        public double WednesdayHours
        {
            get { return wednesday; }
            set { wednesday = value; }
        }
        public double ThursdayHours
        {
            get { return thursday; }
            set { thursday = value; }
        }
        public double FridayHours
        {
            get { return friday; }
            set { friday = value; }
        }
        public double TotalHoursWorked
        {
            get { return totalHours; }
            set { totalHours = value; }
        }
    }
}

