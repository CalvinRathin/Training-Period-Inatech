using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class GstCalculator
    {
        public double item_price;
        public void  GstCalculation() 
        {
            Console.WriteLine("The GST for the product is {0}", item_price*0.2);
        }
    }

    internal class TaxCalculator:GstCalculator
    {
        public void VatCalculation()
        {
            Console.WriteLine("The Vat for the product is {0}", item_price * 0.12);
        }
        public static void Main(string[] args)
        {
            TaxCalculator v1 = new TaxCalculator();
            Console.WriteLine("Enter the price of the item ");
            v1.item_price = Convert.ToDouble(Console.ReadLine());
            v1.GstCalculation();
            v1.VatCalculation();
        }
     }
 
}


