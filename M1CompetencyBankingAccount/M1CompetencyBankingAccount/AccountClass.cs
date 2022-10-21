using System;
namespace M1CompetencyBankingAccount
{
    public class Account
    {
        protected int balance, fee;
        public Account(int balance, int fee)
        {
            Balance = balance;
            Fee = fee;
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public int Fee
        {
            get { return fee; }
            set { fee = value; }
        }
        public int this[string transType]
        {
            set
            {
                if (transType == "d")
                {
                    Balance += (value - fee);
                    //adds the value minus the fee to the balance
                }
                else if (transType == "w")
                {
                    Balance -= (value + fee);
                    //Subtracts the value and the fee from balance
                }
            }
        }
        public void Display()
        {
            double tempBalance = Convert.ToDouble(Balance);
            double tempFee = Convert.ToDouble(Fee);
            Console.WriteLine($"Account has balance of {tempBalance / 100:C2}, fee ${tempFee / 100:C2}");
        }
    }
}

