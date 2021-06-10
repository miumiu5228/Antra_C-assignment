using System;

namespace Exercise7
{
    public class Account
    {
        private int balance;

        public Account(int balance)
        {
            this.balance = balance;
        }

        public void Getbalnce()
        {
            Console.WriteLine($" YOU’RE BALANCE IN Rs: {this.balance}");
        }

        public void WithDraw(int widrawValue)
        {
            this.balance -= widrawValue;
        }

        public void Deposit(int depositValue)
        {
            this.balance += depositValue;
        }

    }
    
 
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Pin Number");
            int pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("********Welcome to ATM Service**************");
            Console.WriteLine();
            Console.WriteLine("1.Check Balance");
            Console.WriteLine();
            Console.WriteLine("2. Withdraw Cash");
            Console.WriteLine();
            Console.WriteLine("3. Deposit Cash");
            Console.WriteLine();
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.WriteLine("**********************************************");
            Console.WriteLine("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            Account account = new Account(1000);
            switch (choice)
            {

                case 1:
                    account.Getbalnce();
                    break;
                case 2:
                    Console.WriteLine("Enter amount: ");
                    int withDrawMoney = Convert.ToInt32(Console.ReadLine());
                    account.WithDraw(withDrawMoney);
                    break;
                case 3:
                    Console.WriteLine("Enter amount: ");
                    int depositmoney = Convert.ToInt32(Console.ReadLine());
                    account.Deposit(depositmoney);
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;

            }
        }

    }
    
}
