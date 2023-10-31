using CompanyG02.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyG02.DAL.Contexts
{
    public class CompanyDbContext:IdentityDbContext<ApplicationUser>
    {//Identity User|Identity Roles
        public CompanyDbContext(DbContextOptions<CompanyDbContext>options ):base(options) 
        {
        
                
        }
          
        
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        // =>   optionsBuilder.UseSqlServer("server=.; database=CompanyMVCG02; integrated sequrity=true;");

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
 