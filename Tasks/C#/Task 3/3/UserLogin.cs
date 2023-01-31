using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class UserLogin
    {
        public UserLogin(string email, string password)
        {
            Console.WriteLine("email : {0} ", email);
            Console.WriteLine("password : {0}", password);
            Console.WriteLine();
        }
        public UserLogin(string membership_id, int pin)
        {

            Console.WriteLine("membership_id : {0}", membership_id);
            Console.WriteLine("pin : {0}", pin);
            Console.WriteLine();
        }
        public UserLogin(double ph_number, int pin)
        {
            Console.WriteLine("ph : {0}", ph_number);
            Console.WriteLine("pin : {0}", pin);
            Console.WriteLine();
        }
        public static void Main() 
        {
            UserLogin u1 = new UserLogin("apple@gmail.com","ACGWSNK");
            UserLogin u2 = new UserLogin("HX357Y", 7895);
            UserLogin u3 = new UserLogin(7971359999, 9084);
        }
    }

    
}
