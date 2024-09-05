using C_SalesWebMVC.Data;
using Microsoft.EntityFrameworkCore;

namespace C_SallesWebMVC.Models.Services
{
    public class SellerServices
    {

        private readonly C_SalesWebMVCContext _context;
        public SellerServices(C_SalesWebMVCContext context)
        {
            _context = context;
        }//dependencia pro DBcontext. (readonly serve para deixar a dependencia inalteravel)

        public List<Seller> FindAll()
        {


            return _context.Seller.ToList();

        }
        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();//corrige o erro da criação de um vendedor 
            _context.Add(obj);
            _context.SaveChanges();
        }
        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id); 
            
        }
        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);    
            _context.SaveChanges();
        }
    }
}
