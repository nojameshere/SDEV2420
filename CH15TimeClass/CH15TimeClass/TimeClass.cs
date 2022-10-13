using System;
namespace CH15TimeClass
{
    public class Time
    {
        private int hours, minutes, seconds;
        public Time(int hrs, int mins, int sec)
        {
            Console.WriteLine($"\nAssigning time with {hrs}, {mins}, and {sec}");
            Hours = hrs;
            Minutes = mins;
            Seconds = sec;
            
        }
        public Time(int hrs, int mins)
        {
            Console.WriteLine($"\nInstantiating a 2-parameter object with hour of {hrs} and minutes of {mins}");
            Hours = hrs;
            Minutes = mins;
            this.seconds = 0;
        }
        public Time(int hrs)
        {
            Console.WriteLine($"\nInstantiating a 1-parameter object with hour of {hrs}");
            Hours = hrs;
            this.minutes = 0;
            this.seconds = 0;
        }
        public int Hours
        {
            get { return hours; }
            set
            {
                if(value >= 0 && value <= 23)
                {
                    hours = value;
                }
                else
                {
                    Console.Write($"The value of {value} is invalid, ");
                    Console.WriteLine("setting hours to 0");
                    hours = 0;
                }
            }
        }
        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    seconds = value;
                }
                else
                {
                    Console.Write($"The value of {value} is invalid, ");
                    Console.WriteLine("setting seconds to 0");
                    seconds = 0;
                }
            }
        }
        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    minutes = value;
                }
                else
                {
                    Console.Write($"The value of {value} is invalid, ");
                    Console.WriteLine("setting minutes to 0");
                    minutes = 0;
                }
            }
        }
        public override string ToString()
        {
            return $"Time: {this.hours}:{this.minutes}:{this.seconds}";
        }
    }
}

