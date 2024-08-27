using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using C_SalesWebMVC.Models;
using C_SallesWebMVC.Models;

namespace C_SalesWebMVC.Data
{
    public class C_SalesWebMVCContext : DbContext
    {
        public C_SalesWebMVCContext (DbContextOptions<C_SalesWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<C_SalesWebMVC.Models.Department> Department { get; set; } = default!;
        public DbSet <Seller> Seller { get; set; }
        public DbSet <SalesRecord> SalesRecord { get; set; }

    }
}
