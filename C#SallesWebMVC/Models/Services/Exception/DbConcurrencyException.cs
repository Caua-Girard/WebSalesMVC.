namespace C_SallesWebMVC.Models.Services.Exception
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string mensage) : base(mensage) 
        {
        
        }
    }
}
