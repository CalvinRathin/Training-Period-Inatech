using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class ElectricityBill
    {
        public static void Main(string[] args)
        {
            int total_bill;
            //int total_bill1;
            //int total_bill2;
            //int total_bill3;
            //int total_bill4;
            Console.WriteLine("Enter your electric bill");
            int electric_bill = Convert.ToInt32(Console.ReadLine());
            if(electric_bill > 0 && electric_bill<=200)
            {
                total_bill = electric_bill*2;
                Console.WriteLine(total_bill);
            }
            else if(electric_bill > 200 && electric_bill<351)
            {
                total_bill =  (200 *2) + (electric_bill - 200) * 3;
                Console.WriteLine(total_bill);
            }
            else if (electric_bill > 350 && electric_bill <=500)
            {
                total_bill = (200*2)+(150*3)+ (electric_bill - 350) * 5;
                Console.WriteLine(total_bill);
            }
            else
            {
                total_bill = (200 * 2) + (150 * 3) + (150 * 5) +((electric_bill-500) * 7);
                Console.WriteLine(total_bill);
            }

        }
    }
}
