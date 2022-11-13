using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountGrowth
{
    internal class Account
    {
        double startingBalance, interestRate, currentBalance;
        public int numCycles;

        public Account(double startingBalance, double interestRate, int numCycles)
        {
            StartingBalance = startingBalance;
            InterestRate = interestRate;
            this.numCycles = numCycles;
            CurrentBalance = startingBalance;
        }
        public double StartingBalance
        {
            get { return startingBalance; }
            set { startingBalance = value; }
        }
        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value / 100; }
        }
        public double CurrentBalance
        {
            get { return currentBalance; }
            set { currentBalance = value; }
        }
        public void RunCycle()
        {
            double interst = currentBalance * InterestRate;
            CurrentBalance = CurrentBalance + interst;
        }
    }
}
