using C_SalesWebMVC.Models;

namespace C_SallesWebMVC.Models.ViewModel
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }

    }
}
