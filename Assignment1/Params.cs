using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Params
    {
       public static void Main(string[] args)
        {
            
            int[] n1 = new int[100];
            int sum=0;
            for (int i = 1; i <6; ++i)
            {
                Console.WriteLine("Enter the value {0}:", i);
                n1[i] = Convert.ToInt32(Console.ReadLine());
            }

           sum= SumOfInteger(n1);
           

            Console.WriteLine("Result={0}", sum);
           // Console.ReadKey();
        }
        static int SumOfInteger(params int[] val)
        {
            int sum = 0;
            foreach (int i in val)
            {
                sum += i;
            }
            return sum;
        }
    }

  
}
