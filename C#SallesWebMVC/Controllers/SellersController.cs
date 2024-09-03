using C_SallesWebMVC.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace C_SallesWebMVC.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerServices _sellerServices;

        public SellersController(SellerServices sellerServices)
        {
            _sellerServices = sellerServices;
        }

        public IActionResult Index()
        {
            var list = _sellerServices.FindAll();//retorna uma lista de seller
            return View(list);     
        }





    }
}
