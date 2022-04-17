using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{


	public class Swap
	{

		public static void Main()
		{
			double x = Convert.ToDouble(Console.ReadLine());
			double y = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("before swapping:{0} {1}", x, y);
			Swapping( x, y,out x,out y);
			Console.WriteLine("After Swapping :{0} ,{1}", x, y);

		}
		public static void Swapping(double x, double y, out double x1, out double y1)
		{

			double temp;
			temp = x;
			x1 = y;
			y1 = temp;
		}
	}


}
