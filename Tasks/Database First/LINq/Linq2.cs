using LINq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINq
{
    internal class Linq2
    {
        public static void Main()
        {
            Food[] foods =
            {
                new Food(){ItemID=01,Item="Choco Shake"},
                new Food(){ItemID=02,Item="Milk Shake"},
                new Food(){ItemID=03,Item="Mango Shake"},
            };

            var qry = from shake in foods
                      select shake.Item;



            foreach ( var f in qry) // to present only one row
            {
                Console.WriteLine(f);
            }

            var qry1 = from shake in foods
                       select shake;

            Console.WriteLine("-------------------------------");

            foreach (Food f in qry1) // to present only one row
            {
                Console.WriteLine(f.ItemID+ " "+ f.Item+" ");
                //if ',' is put then only first column is presented
                //EX: (f.ItemID + " " , f.Item + " ");
            }


        }

    }
    class Food
    {
        public int ItemID { get; set; }
        public string ? Item { get; set; } /*? represents can be nullable*/
    }
}


//var qry1 = from shake in foods
//where shake.Item.Contains(value:"p")
//select shake.Item;