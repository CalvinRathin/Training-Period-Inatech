using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class TvPackage
    {
        public static void Main(string[] args)
        {
            string package;
            
            Console.WriteLine("Package A includes  South Special, Children's Club, Movies");
            Console.WriteLine("Package B includes  News, Sports, Movies, Regional");
            Console.WriteLine("Package C includes  Discovery, History, National");
            Console.WriteLine("Enter The Required package");
            package= Console.ReadLine();
            
            switch(package)
            {
                case "Package A" :
                   
                    Console.WriteLine("Rate : 250 ");
                    break;
                case "Package B":
                    
                    Console.WriteLine("Rate : 450 ");
                    break;
                case "Package C":
                    
                    Console.WriteLine("Rate : 350");
                    break;
                default:
                    Console.WriteLine("The package that you are looking for is either not available or check for any case sensitive errors");
                    break;
            }
        }
    }
}
