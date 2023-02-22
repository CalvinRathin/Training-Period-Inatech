using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINq
{
    public class Linq1 
    {
        public static void Main()
        {
            string[] name1 = { "SJ", "Vigneshwar", "Eren Yeager", "Bankai" };
            var qry = from name in name1
                      select name;
            Console.WriteLine("ALL NAMES");

            foreach (var item in qry)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");
            var qry1 = from name in name1
                       where name.Contains("e")
                       select name;
            Console.WriteLine("NAME CONTAINS E");
            foreach (var item in qry1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("Students details BY USING CODE");

            Student[] studata = { new Student() { Id = 1, Name = "Ichigo", age = 20 ,branchID=1 },
            new Student(){ Id=2,Name="Rukia",age=23,branchID=1},
            new Student(){Id=3,Name="Abarai",age=25, branchID = 2}
            };
            foreach (Student s in studata)
            {
                Console.WriteLine(s.Id + " " + s.Name + " " + s.age);
            }

            Console.WriteLine(" BY USING QUERRY");
            var qr = from Student in studata
                     where Student.Id == 1
                     select Student.Name;
            foreach (string s in qr)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-------------------------");
            var stuqr = from Student in studata
                        where Student.IsEmployable(Student)
                        select Student;

            foreach (Student s in stuqr)
            {
                Console.WriteLine(s.Id + " " + s.Name + " " + s.age);
            }
            Console.WriteLine("-------------------------");
            var EmployableStudents = studata.Where(s => s.age > 18 && s.age < 24);

            //lambda function eg 

            foreach (Student st in EmployableStudents)
            {
                Console.WriteLine(st.Name + " " + st.age);
            }
            Console.WriteLine("EVEN NUMBERS");
            var EvenRows = studata.Where((j, i) =>
            {
                if (i % 2 == 0) return true;
                return false;
            });
            foreach (Student s in EvenRows)
            {
                Console.WriteLine(s.Name + " " + s.Id);
            }

            Console.WriteLine("---------------------------------------");

            Subjects[] sub1 = {
            new Subjects() { Topic = "International Politics", Subject = "bob" },
            new Subjects() { Topic = "International Cuisine", Subject = "tom" },
            new Subjects() { Topic = "International Politics", Subject = "gom" },
            new Subjects() { Topic = "International Politics", Subject = "dom" },
             };

            var EvenRows2 = sub1.Where((p, l) =>
            {
                if (l % 2 == 0) return true;
                return false;
            });

            foreach (var row in EvenRows2)

                Console.WriteLine(row.Topic + " " + row.Subject);

            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Faculty based list");
            var FacQry = from sd in sub1
                         orderby sd.Subject
                         select sd;
            foreach (Subjects ss in FacQry)
                Console.WriteLine(ss.Subject);

            Console.WriteLine("---------------------------------------");
            /*
             * 
             * var qrry = from sa in
             * 
             * foreach (student s in studata)
             * {
             * Console.WriteLine(s.ID+" "+S.Name+" "+S.Age);
             * }
             * 
             * 
             * 
             * 
             */



            //Console.WriteLine(v.Name + " " + v.BranchName);

            IList<Branch> branchData = new List<Branch>()
            {
                new Branch() { BranchId = 1, BranchName = "Computer Science" },
            new Branch() { BranchId = 2, BranchName = "IT" },
            new Branch() { BranchId = 3, BranchName = "ECE" }
            };

            var JoinData = studata.Join(
                branchData,
                stu => stu.branchID,
                brd => brd.BranchId,
                (stu, brd) => new
                {
                    Name1 = stu.Name,
                    BranchName1 = brd.BranchName,
                });
            foreach(var v in JoinData)
            {
                Console.WriteLine(v.Name1+" "+v.BranchName1);
            }

        }

    }



        public class Student
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public int age { get; set; }

            public int branchID { get; set; }
            public static bool IsEmployable(Student student)
            {
                return student.age > 18 && student.age < 24;
            }


        }
    public class Branch
    { public int BranchId { get; set; }
    public string? BranchName { get; set; }
    }
        
    
    class Subjects
    {
        public string? Topic { get; set; }
        public string? Subject { get; set; }

    }
}
    





