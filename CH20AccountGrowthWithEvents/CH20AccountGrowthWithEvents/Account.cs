using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountGrowth
{
    public class Account
    {
        public delegate void AccountDelegate(string message);
        public event AccountDelegate AccountHundred;
        public event AccountDelegate AccountDoubled;
        double startingBalance, interestRate, currentBalance;
        public int numCycles;
        public bool hundredPassed = false;
        public bool balanceDoubled = false;

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
            if ((CurrentBalance > 100) && (!hundredPassed))
            {
                AccountHundred?.Invoke("** Account just passed $100 in value");
                hundredPassed = true;
            }
            if ((currentBalance >= (startingBalance * 2)) && (!balanceDoubled))
            {
                AccountDoubled?.Invoke("** Account just doubled in value");
                balanceDoubled = true;
            }
        }
        
    }
}
