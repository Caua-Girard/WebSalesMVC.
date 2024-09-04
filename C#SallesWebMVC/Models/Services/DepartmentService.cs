using C_SalesWebMVC.Data;
using C_SalesWebMVC.Models;

namespace C_SallesWebMVC.Models.Services
{
    public class DepartmentService
    {
        private readonly C_SalesWebMVCContext _context;
        public DepartmentService(C_SalesWebMVCContext context)
        {
            _context = context;
        }//dependencia pro DBcontext. (readonly serve para deixar a dependencia inalteravel)    
        public List<Department> FindAll()
        { 
            return _context.Department.OrderBy(x => x.Name).ToList();  
        }
    }
}
