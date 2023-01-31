using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public abstract class Calculator
    {
        public int num1, num2;
        public abstract void Addition();
        public abstract void Subtraction();
        public abstract void Multiply();
        public abstract void Divide();
           
    }
    public class CalculatorDefinition : Calculator
    {
        public override void Addition()
        {
            Console.WriteLine(num1+num2);
        }
        public override void Subtraction()
        {
            Console.WriteLine(num1 - num2);
        }
        public override void Multiply()
        {
            Console.WriteLine(num1 * num2);
        }
        public override void Divide()
        {
            try
            {
                Console.WriteLine(num1 / num2);
            }
            catch(Exception e) 
            {
                

            }
        }

        public static void Main(string[] args)
        {
            CalculatorDefinition c1 = new CalculatorDefinition();
            Console.WriteLine("Enter num1");
             c1.num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
             c1.num2 = Convert.ToInt32(Console.ReadLine());
            c1.Addition();
            c1.Subtraction();
            c1.Multiply();
            c1.Divide();

        }
    }
}
