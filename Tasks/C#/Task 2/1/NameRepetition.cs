using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class NameRepetition
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age ");
            int age = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<age;i++) 
            {
                Console.WriteLine(name);
            }
        }
    }
}
