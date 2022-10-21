namespace M1CompetencyBankingAccount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Stuff goes here
            Console.WriteLine("Module 1 Competency Assignemnt - Bank Account by James Sales");

            Console.WriteLine("\nSet up the account");
            Console.Write("What is the starting balance? $");
            double balance = double.Parse(Console.ReadLine());
            balance *= 100;
            Console.Write("What is the fee for this account? $");
            double fee = double.Parse(Console.ReadLine());
            fee *= 100;
            //Create account here
            Account account = new Account(Convert.ToInt32(balance), Convert.ToInt32(fee));

            //Loop for transactions
            bool cont = true;
            string selection;
            string response;
            while (cont)
            {
                double enteredValue;
                Console.Write("\nW - Withdraw, D - Deposit, B - Check Balance, Q - Exit transactions: ");
                selection = Console.ReadLine().ToLower();
                switch (selection)
                {
                    case "w":
                        //code for withdraw
                        Console.Write("How much would you like to withdraw? $");
                        enteredValue = double.Parse(Console.ReadLine());
                        if (account.Balance - ((enteredValue * 100) + account.Fee) >= 0)
                        {
                            //code for successful withdraw
                            account[selection] = Convert.ToInt32(enteredValue * 100);
                            account.Display();
                        }
                        else
                        {
                            Console.WriteLine("Insifficient funds for requested withdrawal");
                            account.Display();
                        }
                        break;
                    case "d":
                        //code for deposit
                        Console.Write("How much would you like to deposit? $");
                        enteredValue = double.Parse(Console.ReadLine());
                        account[selection] = Convert.ToInt32(enteredValue * 100);
                        account.Display();
                        break;
                    case "b":
                        //code for displaying the balance
                        account.Display();
                        break;
                    case "q":
                        //code to exit loop
                        cont = false;
                        break;
                    default:
                        Console.WriteLine("Invalid transaction selection");
                        break;
                }
                //check if user has any more transactions
                Console.Write("\nDo you have any more transactions?");
                response = Console.ReadLine().ToLower();
                if (response == "n")
                {
                    cont = false;
                }
                else if (response == "y")
                {
                    cont = true;
                }
            }
            Console.WriteLine("Thank you for banking with us.");
            Console.WriteLine("\nDo you mind pressing a key to exit the program?");
            Console.ReadKey();
        }
    }
}