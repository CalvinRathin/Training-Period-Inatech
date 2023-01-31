using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Task6B
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public void display()
        {
            FileStream fs=new FileStream("D:\\Training Program\\employee1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr=new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            sr.ReadToEnd();
        }

        public static void Main(string[] args)
        {
            Task6B emp= new Task6B();
            Console.WriteLine("Enter the name of employee : ");
            emp.Name = Console.ReadLine();
            Console.WriteLine("Enter the GENDER: ");
            emp.Gender = Console.ReadLine();
            Console.WriteLine("Enter the age :");
            emp.Age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the id :");
            emp.Id = Convert.ToInt32(Console.ReadLine());


            FileStream f1 = new FileStream(@"D:\Training Program\employee1.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(f1);
            sw.WriteLine(emp.Name);
            sw.WriteLine(emp.Gender);
            sw.WriteLine(emp.Age);
            sw.WriteLine(emp.Id);
            sw.Flush();
            sw.Close();
            f1.Close();
            emp.display();
        }

    }
    
}
