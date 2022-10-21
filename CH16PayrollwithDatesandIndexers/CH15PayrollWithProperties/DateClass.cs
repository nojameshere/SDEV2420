using System;
namespace CH15PayrollWithProperties
{
    public class Date
    {
        private int year, month, day;

        int[] monthsArray = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public Date(int yyyy, int mm, int dd)
        {
            Year = yyyy;
            Month = mm;
            Day = dd;
        }
        public int Year
        {
            get { return year; }
            set
            {
                int YYYY = value;
                if (YYYY < 100)
                {
                    YYYY += 2000;
                }
                if (YYYY >= 1700 && YYYY <= 2200)
                {
                    year = YYYY;
                }
                else
                {
                    Console.WriteLine("Use of invalid year, setting to default of 2001");
                    year = 2001;
                }
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if (value > 0 && value <= 12)
                {
                    month = value;
                }
                else
                {
                    Console.WriteLine("Use of invalid month, setting to default of 1");
                    month = 1;
                }
            }
        }
        public int Day
        {
            get { return day; }
            set
            {
                int daysInMonth = monthsArray[this.month];
                if (this.month == 2 && this.year % 4 == 0)
                {
                    daysInMonth = 29;
                }
                if (value > 0 && value <= daysInMonth)
                {
                    day = value;
                }
                else
                {
                    Console.WriteLine("Use of invalid day, setting to default of 1");
                    day = 1;
                }
            }
        }
        public void addDay(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int daysInMonth = monthsArray[this.month];
                if (this.month == 2 && this.year % 4 == 0)
                {
                    daysInMonth = 29;
                }
                if (this.month == 12 && this.day == 31)
                {
                    this.year++;
                    this.month = 1;
                    this.day = 1;
                }
                else if (this.day == daysInMonth)
                {
                    this.day = 1;
                    if (this.month == 12)
                    {
                        this.month = 1;
                    }
                    else
                    {
                        this.month++;
                    }
                }
                else
                {
                    this.day++;
                }
                if (this.day == 0) { this.day++; }
                Console.WriteLine(this.ToString());
            }
        }
        public int this[string thing]
        {
            get
            {
                if (thing == "mon")
                {
                    return month;
                }
                else if (thing == "day")
                {
                    return day;
                }
                else if (thing == "yr")
                {
                    return year;
                }
                else 
                {
                    Console.WriteLine("invalid input on date indexer");
                    return -1;
                }
            }
        }
        public override string ToString()
        {
            return $"{month}/{day}/{year}";
        }
    }
}

