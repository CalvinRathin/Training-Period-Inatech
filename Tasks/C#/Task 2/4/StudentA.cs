using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class StudentA
    {
        public static void Main(string[] args)
        {
            float total= 0;
            float[] marks = new float[] { 80, 67, 75, 94, 57 };
            for(int i=0;i<marks.Length;i++) 
            {
                total = marks[i]+total;
            }
            Console.WriteLine("Total : {0}", total);
            Console.WriteLine("Percentage : {0}", total / 5);
        }

    }
}
