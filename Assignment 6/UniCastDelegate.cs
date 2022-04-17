using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{ /*UniCast Delegate*/
    public delegate void EmployeeDelegate();
    public class UniCastDelegate
    {
        
        static void Main(string[] args)
        {
            Employee employee = new Employee();

          
            EmployeeDelegate employeeDelegate = new EmployeeDelegate(employee.Display);


            employeeDelegate.Invoke();


        }
    }
    public class Employee
    {
        private int empId;
        private string empName;
        private string companyName;
        private string designation;
        private string workLocation;

        

        public Employee()
        {
            Console.Write("Enter the emp id : ");
            this.empId =( Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter the emp name : ");
            this.empName = Console.ReadLine();

            Console.Write("Enter the Company Name : ");
            this.companyName = Console.ReadLine();

            Console.Write("Enter the emp designation : ");
            this.designation = Console.ReadLine();

            Console.Write("Enter the emp WorkLocation : ");
            this.workLocation = Console.ReadLine();

        }

        public void Display()
        {
            Console.WriteLine("Employee Id : {0}",empId);
            Console.WriteLine("Employee Name : {0}",empName);
            Console.WriteLine("Employee Company Name : {0}",companyName );

            Console.WriteLine("Employee Designation : {0}",designation);

            Console.WriteLine("Employee Work Location : {0}",workLocation);
        }



    }
}
