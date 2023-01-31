using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Employees
    {
        public int e_id;
        public string name;
        public string gender;
        public int years_of_experience;
        public double salary;
        public string department;
        public void getdetails()
        {
            Console.WriteLine("Enter the employee id : ");
            e_id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the name : ");
            name = Console.ReadLine();

            Console.WriteLine("Enter the employee gender (m or f) : ");
            gender = Console.ReadLine();

            Console.WriteLine("Enter the years_of_experience : ");
            years_of_experience = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Salary : ");
            salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the department : - sales or production ");
            department = Console.ReadLine();

            switch(department)
            {
                case "sales":
                    Console.WriteLine("The Entered Salary is : {0} ",salary);
                    Console.WriteLine("Sales get 20 % bonus of their salary ; bonus = {0} ",salary*0.2);
                    Console.WriteLine("Salary along with bonus : ",salary+(salary*0.2));
                    break;
                case "production":
                    Console.WriteLine("The Entered Salary is : {0} ", salary);
                    Console.WriteLine("Production get 10 % bonus of their salary ; bonus = {0} ", salary * 0.1);
                    Console.WriteLine("Salary along with bonus : {0}", salary + (salary * 0.1));
                    break;

                default: 
                    Console.WriteLine("Retype the department name in lowercase");
                    break;
            }
        }
        

    }
    internal class EmployeeDetails : Employees
    {
        public static void Main(string[] args)
        {
            EmployeeDetails e1 = new EmployeeDetails();
            e1.getdetails();
            Console.WriteLine("********************");
            EmployeeDetails e2 = new EmployeeDetails();
            e2.getdetails();
            Console.WriteLine("********************");
        }
    }
}
