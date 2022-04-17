using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{


    public class AvgMarks
    {

        public static void Main()
        {
            int num1, num2, choice;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("simple calculator:\n");
            Console.Write("------------------------------------------------");
            Console.Write("\n\n");
            //Collecting two digits to perform calculator operation
            Console.Write("Enter the first Integer :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second Integer :");
            num2 = Convert.ToInt32(Console.ReadLine());

            // which operation need to do:-
            Console.Write("\nHere are the options :\n");
            Console.Write("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.");
            Console.Write("\nInput your choice :");
            choice = Convert.ToInt32(Console.ReadLine());


            //switch case operation to perform task 
            switch (choice)
            {
                case 1:
                    Console.Write("The Addition of  {0} and {1} is: {2}\n", num1, num2, num1 + num2);
                    break;

                case 2:
                    Console.Write("The Substraction of {0}  and {1} is: {2}\n", num1, num2, num1 - num2);
                    break;

                case 3:
                    Console.Write("The Multiplication of {0}  and {1} is: {2}\n", num1, num2, num1 * num2);
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.Write("Cannot divide by Zero.\n");
                    }
                    else
                    {
                        Console.Write("The Division of {0}  and {1} is : {2}\n", num1, num2, num1 / num2);
                    }
                    break;
                default:
                    Console.Write("Input correct option\n");
                    break;

            }
        }


    }
}
