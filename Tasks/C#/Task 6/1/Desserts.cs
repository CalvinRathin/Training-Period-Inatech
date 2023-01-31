using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
namespace Homework
{
    internal class Desserts
    {
        public static void Main(string[] args)
        {
            
            ArrayList item = new ArrayList();
            item.Add("The Menu Of Deserts From Restaurant ");
            item.Add("1 . Mysorpa");
            item.Add("2 . Chocolate Icecream");
            item.Add("3 . Gulab Jamun");
            item.Add("4 . Strwberry Icecream");

            //Access the file , read and write file
            
            FileStream fs = new FileStream(@"D:\Training Program\sampleX.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            foreach (object i in item)
            {
                sw.WriteLine(i);
            }
            sw.Flush();
            sw.Close();
            fs.Close();

            //time of creation of file and file size

            FileInfo f1 = new FileInfo(@"D:\Training Program\sampleX.txt");
            f1.CreationTime = DateTime.Now;
            Console.WriteLine("Creation Time is : {0}", f1.CreationTime);
            Console.WriteLine("the file size is : {0}", f1.Length);

        }
    }
}
