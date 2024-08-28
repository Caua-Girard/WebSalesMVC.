using Microsoft.AspNetCore.Mvc;

namespace C_SallesWebMVC.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
