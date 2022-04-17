using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using LitWareLib;


namespace ConsoleApp3
{
    public class Employee
    {
      public  static void Main()
        {
            string myPath = @"D:\Binary\Test1.save";

            string mySecondPath = @"D:\Binary\New1.txt";

            Console.Write("Enter the salary of an Employee to find Food ,Petrol,Other Allowances :");
            Manager m = new Manager(Convert.ToInt32(Console.ReadLine()));

            m.Foodie();
            m.Petrol();
            m.Others();

            m.GrossSalary();
            m.CalculateSalary();
            m.Mprint();

            /* Deserialize first object*/

            DataSerializer ds = new DataSerializer();

            


            ds.BinarySerialize(m, myPath);
            Console.WriteLine("Test Deserialize");




            FileStream fs = new FileStream(myPath, FileMode.OpenOrCreate);
            BinaryFormatter bs = new BinaryFormatter();
            Manager mm = (Manager)bs.Deserialize(fs);
            Console.WriteLine("Successfully Deserialized And Deserialized The object");
            Console.WriteLine("");
            Console.WriteLine("Manager salary:{0}", mm.CalculateSalary());


            Console.WriteLine("Manager salary {0}:", mm);

            fs.Close();


            Console.Write("Enter the salary of an Employee to find Tele and Tour Allowances:");

            MarketingExecutive me = new MarketingExecutive(Convert.ToDouble(Console.ReadLine()));
            me.Grosssalary();
            me.CalculateSalary();
            me.Mprint();

            /*Desrialized second object*/
            DataSerializer dss = new DataSerializer();


            ds.BinarySerialize(me, mySecondPath);
            Console.WriteLine("Test Deserialize");

            FileStream fss = new FileStream(mySecondPath, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            MarketingExecutive marketingExecutive = (MarketingExecutive)bf.Deserialize(fss);
            Console.WriteLine("Successfully Deserialized And Deserialized The object");
            Console.WriteLine("");

            Console.WriteLine("MarketingExecutive salary After deserialized:{0}", marketingExecutive.CalculateSalary());

            fss.Close();

        }
    }
}
