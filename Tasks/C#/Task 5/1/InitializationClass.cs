using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
        public class Program
        {
            public string Name { get; set; }
            public int Age { get; set; }
            // Initialize with object
            public Program()
            {
                Name = "Abc";
                Age = 20;
            }

            // Initialize by passing parameters
            public Program(string name, int age)
            {
                Name = name;
                Age = age;
            }

            static void Main(string[] args)
            {
                // Initialize with object
                Program obj1 = new Program();
                Console.WriteLine("Object 1: Name: {0}, Age: {1}", obj1.Name, obj1.Age);

                // Initialize by passing parameters
                Program obj2 = new Program("Abc", 20);
                Console.WriteLine("Object 2: Name: {0}, Age: {1}", obj2.Name, obj2.Age);
            }
        }

    }

