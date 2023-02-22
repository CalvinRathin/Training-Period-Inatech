using KoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace KoreMVC.Controllers
{
    public class SampleController : Controller
    {
        public string hello()
        {
            return "Lifeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee";
        }
        public string Names(string name)
        {
            return "Hello "+ name;
        }
        public string Data(string name,int no=10)
        {
            return "Hello " + name + " you got "+no;
        }

        public IActionResult Index(string name, int no=0)
        {
            ViewData["name"] = name;
            ViewData["no"] = no;
            return View();
        }
        public IActionResult Display(string name, int no)
        {
            ViewData["name"] = name;
            ViewData["no"] = no;
            return View();
        }
        public IActionResult GetCustomer()
        {
            Customer cust = new Customer() { CustomerId=99,CustomerName="dom",Number= "7871358345",City= "Chennai",Gender= "M" };
            return View("GetCust",cust); 
        }
        public IActionResult NewCustomer(string name) 
        {
          return View();
        }

        public IActionResult Submitop(Customer cust) // WE CHANGE NAME IN form asp-action IN NEWCUSTOMER
        {
            //return RedirectToAction("GetCustomer");
            return View("GetCust", cust);
        }
    }
}
