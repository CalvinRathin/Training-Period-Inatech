using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Operations
    {
        public int num1;//public is used so that the variables can be accessed by derived class
        public int num2;
        public void addition()
        {
            Console.WriteLine("Addition of 2 numbers : {0} ", num1 + num2);
        }
        public void subtraction()
        {
            Console.WriteLine("Subtraction of 2 numbers : {0} ", num1 - num2);
        }
    }
    public class ArithmeticOperation : Operations 
    {
        public void multiplication()
        {
            Console.WriteLine("Multiplication of 2 numbers : {0}", num1 * num2);
        }
        public void division()
        {
            try
            {
                Console.WriteLine("Division of 2 numbers : {0}", num1 / num2);
            }
            catch ( Exception e) 
            { 
                Console.WriteLine("Cannot divide the number by 0");
            }
        }
        public static void Main(string[] args) 
        {
            ArithmeticOperation obj1 = new ArithmeticOperation();
            Console.WriteLine("Enter the first number : ");
            
            obj1.num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            obj1.num2 = Convert.ToInt32(Console.ReadLine());
            obj1.addition();
            obj1.subtraction();
            obj1.multiplication();
            obj1.division();

        }
    }
}
