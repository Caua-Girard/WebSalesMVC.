using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using C_SallesWebMVC.Models;

namespace C_SallesWebMVC.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronics" });
            list.Add(new Department { Id = 2, Name = "Fashion" });   

            return View(list);
        }
    }
}
