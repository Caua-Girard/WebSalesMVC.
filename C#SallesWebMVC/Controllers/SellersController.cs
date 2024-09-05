using C_SallesWebMVC.Models;
using C_SallesWebMVC.Models.Services;
using C_SalesWebMVC.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using C_SallesWebMVC.Models.ViewModel;


namespace C_SallesWebMVC.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerServices _sellerServices;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerServices sellerServices, DepartmentService departmentService)
        {
            _sellerServices = sellerServices;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var list = _sellerServices.FindAll();//retorna uma lista de seller
            return View(list);
        }



        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments };

            return View(viewModel);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerServices.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _sellerServices.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _sellerServices.Remove(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _sellerServices.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        

        }
    }
}

