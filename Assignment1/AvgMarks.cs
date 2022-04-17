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

            int[] n = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter avg marks obtained by student {0}:", i + 1);
                n[i] = Convert.ToInt32(Console.ReadLine());

            }
            int MaxVal = 0;
            for (int i = 0; i < n.Length; i++)
            {
               
                if (MaxVal < n[i])
                {
                    MaxVal = n[i];
                    
                }

            }
            Console.WriteLine("---------------");
            Console.WriteLine("Highest narks obtained::" + MaxVal);
        }
	}


}
