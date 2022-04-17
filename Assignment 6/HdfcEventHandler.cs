using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    


    class Hdfc
    {

       public event EventHandler UnderBalnce;

       public event EventHandler ZeroBalance;

       public event EventHandler WithdrawLimit;



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
            Console.WriteLine("WithDraw Section::::::::::");

          
        }
        public void Withdraw()
        {
            Console.WriteLine("Enter Customer Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Withdraw Amount :");
            withdraw = Convert.ToDouble(Console.ReadLine());
            if (withdraw>=1000)
            {
                totalbal = balance - withdraw;

                Console.WriteLine("Customer Name: " + name);
                Console.WriteLine("Account Number: " + account);
                Console.WriteLine("Amount after Withdraw : " + totalbal);
            }
            if (withdraw < 1000)
            {
                WithdrawLimit.Invoke(this, EventArgs.Empty);

            }
            if(withdraw==balance)
            {
                
                ZeroBalance.Invoke(this, EventArgs.Empty);
            }
            if (withdraw > balance)
            {
                UnderBalnce.Invoke(this, EventArgs.Empty);
            }
          

        }

    }
    class HdfcEventHandler
    {
        static void Main(string[] args)
        {
            Hdfc account = new Hdfc();

            account.UnderBalnce += UnderBalance;
            account.ZeroBalance += ZeroBalance;
            account.WithdrawLimit += WidthDrawLimit;
            account.Deposit();
            account.Withdraw();

           


            Console.ReadKey();
        }
        public static void UnderBalance(object sender ,EventArgs e)
        {
            Console.WriteLine("My Event Handeler Under balance is called out");
        }
        public static void ZeroBalance(object sender, EventArgs e)
        {
            Console.WriteLine("My Event Handeler Zero balance is called out");
        }
        public static void WidthDrawLimit(object sender, EventArgs e)
        {
            Console.WriteLine("Transaction cannot be continued below specified limit Of Rs.1000");
        }
    }

}