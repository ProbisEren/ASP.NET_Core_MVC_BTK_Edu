using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            String message = $"hello world {DateTime.Now.ToString()}";
            return View("Index1",message);
        }

        public ViewResult Index2()
        {
            var names = new String[]
            {
                "Metin",
                "Eren",
                "Gamze"

            };
            return View(names); 

            // return View("Index"); 
            //  aynı isimdeki(Index2) view'e değil de "Index" isimli view'e git
        }

        public IActionResult Index3()
        {
            var emp_list = new List<Employee>()
            {
                new Employee (){ID = 1, FirstName = "Metin Eren", Surname= "uzun",Age=22},   
                new Employee (){ID = 2, FirstName = "Gamze", Surname= "partal",Age=23},   
                new Employee (){ID = 3, FirstName = "Ahmet Mehmet", Surname= "nokta",Age=35},   
                new Employee (){ID = 4, FirstName = "asd", Surname= "qwe",Age=10} 

            };
            return View(emp_list);
        }

        public IActionResult Index4()
        {
            return View();
        }
    }
}