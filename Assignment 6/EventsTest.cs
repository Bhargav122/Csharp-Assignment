using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public delegate void UnderBalanceEventHandler();
    class Account
    {
        
        public event UnderBalanceEventHandler UnderBalance;


        private double balance = 10000;
        string bank;
        string name;
        int account;
        double withdraw, deposit, totalbal;


        public void Deposit()
        {
            Console.WriteLine("Enter Customer name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Deposit Amount :");
            deposit = Convert.ToDouble(Console.ReadLine());
            totalbal = balance + deposit;


            Console.WriteLine("Customer Name : " + name);
            Console.WriteLine("Account Number: " + account);
            Console.WriteLine("Total Amount After Deposit  : " + totalbal);

        }
        public void Withdraw()
        {
            Console.WriteLine("Enter Customer Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Withdraw Amount :");
            withdraw = Convert.ToDouble(Console.ReadLine());
            if (withdraw <= balance)
            {
                totalbal = balance - withdraw;

                Console.WriteLine("Customer Name: " + name);
                Console.WriteLine("Account Number: " + account);
                Console.WriteLine("Amount after Withdraw : " + totalbal);
            }
            else
                Console.WriteLine("\n\nUnder balance");
        }

    }
    class EventsTest
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            UnderBalanceEventHandler MD = new UnderBalanceEventHandler(account.Withdraw);
            MD += new UnderBalanceEventHandler(account.Deposit);
            MD.Invoke();
            Console.ReadKey();
        }
    }

}