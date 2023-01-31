using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class ProductList
    {
        public static void Main(string[] args)
        {
            string[][] products = new string [4][];//JAGGED ARRAY
            products[0] = new string[3] {"List","Product Category","No of Items"};
            products[1] = new string[3] { "a.","biscuits","There are 5 items"};
            products[2] = new string[3] { "b.", "Chocolates", "There are 5 items" };
            products[3] = new string[3] { "c.", "biscuits", "There are 6 items" };
           
            for(int i=0;i<products.Length;i++)
            { 
                for(int j = 0; j < products[i].Length;j++) 
                
                    Console.WriteLine(products[i][j]+"\t");
                
                Console.WriteLine();
            }
        }
    }
}
