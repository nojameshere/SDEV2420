using System;
namespace CH16WeeklySaleswithIndexers
{
    public class DailySales
    {
        protected double[] sales = new double[5];
        protected string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri" };
        protected static double total = 0;
        public DailySales()
        {
            sales[0] = 0;
            sales[1] = 0;
            sales[2] = 0;
            sales[3] = 0;
            sales[4] = 0;
        }
        public double this[string day]
        {
            get
            {
                if (day == "Mon") { return sales[0]; }
                else if (day == "Tue") { return sales[1]; }
                else if (day == "Wed") { return sales[2]; }
                else if (day == "Thu") { return sales[3]; }
                else if (day == "Fri") { return sales[4]; }
                else { return -1; }
            }
            set
            {
                if (day == "Mon") { sales[0] = value; }
                else if (day == "Tue") { sales[1] = value; }
                else if (day == "Wed") { sales[2] = value; }
                else if (day == "Thu") { sales[3] = value; }
                else if (day == "Fri") { sales[4] = value; }
                else Console.WriteLine("Day error");
            }
        }
        public double this[int index]
        {
            get { return sales[index]; }
            set { sales[index] = value; }
        }
        public void Display()
        {
            Console.WriteLine($"\n{days[0]}      {days[1]}      {days[2]}      {days[3]}      {days[4]}");
            Console.WriteLine($"{sales[0]:C2}    {sales[1]:C2}    {sales[2]:C2}    {sales[3]:C2}    {sales[4]:C2}");
        }
        public double Total
        {
            get { return total; }
            set { total += value; }
        }
        public void CalcTotal()
        {
            foreach (double total in sales)
            {
                Total = total;
            }
        }
    }
}

