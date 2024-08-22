using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using C_SallesWebMVC.Models;

namespace C_SallesWebMVC.Data
{
    public class C_SallesWebMVCContext : DbContext
    {
        public C_SallesWebMVCContext (DbContextOptions<C_SallesWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<C_SallesWebMVC.Models.Department> Department { get; set; } = default!;
    }
}
