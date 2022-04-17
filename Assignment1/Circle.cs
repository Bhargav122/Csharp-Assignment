using System;
public class Circle
{
    public static void Main()
    {

        double r, _Area,_Circumference ;
        double PI = 3.14;
        Console.WriteLine("Input the radius of the circle : ");
        r = Convert.ToDouble(Console.ReadLine());
        _Area =  PI * r * r;
        Console.WriteLine("Area of Circle : {0}", _Area);
        _Circumference = 2 * PI * r;
        Console.WriteLine("Circumference of Circle : {0}", _Circumference);

    }
}