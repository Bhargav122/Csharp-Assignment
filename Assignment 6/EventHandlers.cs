using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    


    class Icici
    {

       public event EventHandler UnderBalnce;

       public event EventHandler ZeroBalance;


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
            if (withdraw < balance)
            {
                totalbal = balance - withdraw;

                Console.WriteLine("Customer Name: " + name);
                Console.WriteLine("Account Number: " + account);
                Console.WriteLine("Amount after Withdraw : " + totalbal);
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
    class EventHandlers
    {
        static void Main(string[] args)
        {
            Icici account = new Icici();

            account.UnderBalnce += UnderBalance;
            account.ZeroBalance += ZeroBalance;
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
    }

}