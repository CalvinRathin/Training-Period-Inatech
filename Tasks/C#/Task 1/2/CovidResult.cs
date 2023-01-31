using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class CovidResult
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Do you have travel history : Y or N ");
            char ans1 = Console.ReadKey().KeyChar;
            if (ans1 == 'Y' || ans1 == 'y')
            {
                Console.WriteLine("  Do you have temperature ? : Y or N ");
                Console.WriteLine();
                char ans2 = Console.ReadKey().KeyChar;
                if (ans2 == 'Y' || ans2 == 'y')
                {
                    Console.WriteLine("  Do you have have cough/sneeze");
                    Console.WriteLine();
                    char ans3 = Console.ReadKey().KeyChar;
                    if (ans3 == 'Y' || ans3 == 'y')
                    {
                        Console.WriteLine(" Swab Test");
                        Console.WriteLine();
                    }
                    else if (ans3 == 'N' || ans3 == 'n')
                    {

                        Console.WriteLine("  Quarantine,Fever Medicine");
                        Console.WriteLine();
                    }
                    //else if (ans2 == 'N' || ans2 == 'n')
                    //{

                    //    Console.WriteLine(" Home Quarantine for 28 days");
                    //}

                }
                else if (ans2 == 'N' || ans2 == 'n')
                {

                    Console.WriteLine("  Home Quarantine for 28 days");
                    Console.WriteLine();
                }

            }
            else
            {

                Console.WriteLine("  Safe! not Covid");
            }
        }
    }
}
