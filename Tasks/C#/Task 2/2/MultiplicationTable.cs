using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class MultiplicationTable
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for displaying its numbers table :");
            int number=Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=20; i++) 
            {
                Console.WriteLine("{0}*{1}={2}",number,i,number * i);
            }

        }
    }
}
