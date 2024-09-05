namespace C_SallesWebMVC.Models.Services.Exception
{
    public class NotFoundException : ApplicationException 
    { 
        public NotFoundException (string message) : base (message) 
        {
        } 
    }
}
