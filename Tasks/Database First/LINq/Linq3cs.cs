using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static LINq.Linq1;

namespace LINq
{
    public class Linq3cs
    {
        public static void Main()
        {
            IList hlist = new ArrayList();
            hlist.Add(1);
            hlist.Add(2);
            hlist.Add("three");
            hlist.Add(new Student() { Id = 1, Name = "DOSS" });
            var hlistStu = from s in hlist.OfType<Student>()
                           select s;
            var hlistInt = from s in hlist.OfType<int>()
                           select s;
            var hlistVal = from s in hlist.OfType<string>()
                           select s;
            foreach (Student stu in hlistStu)
                Console.WriteLine(stu.Name);
            foreach(var x in hlistInt)Console.WriteLine(x);
            foreach (var s in hlistVal) Console.WriteLine(s);



        } 
    }
}
