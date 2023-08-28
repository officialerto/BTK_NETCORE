using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers 
{

    public class EmployeeController : Controller
    {   
        public IActionResult Index1(){
            string message = $"Hello world. {DateTime.Now.ToString()}";
            return View("Index1", message);
        }

        public ViewResult Index2(){
            var names = new String[]
            {
                "Ahmet",
                "Mehmet",
                "Can"
            };
            return View(names);
        }

        public IActionResult Index3(){

            var list = new List<Employee>
            {
                new Employee(){Id=1, FirstName="Ahmet", LastName="Muratsaki", Age=33},
                new Employee(){Id=2, FirstName="Can", LastName="Tuzlu", Age=21},
                new Employee(){Id=3, FirstName="Maroş", LastName="Kırka", Age=24}
            };
            return View("Index3", list);
        }
        
    }
    
}