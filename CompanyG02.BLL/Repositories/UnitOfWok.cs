using CompanyG02.BLL.Interfaces;
using CompanyG02.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyG02.BLL.Repositories
{
    public class UnitOfWok : IUnitOfWok
    {
        private readonly CompanyDbContext dbContext;

        public IEmployeeRepository EmployeeRepository { get; set; }
        public IDepartmentRepository DepartmentRepository { get; set; }
        public UnitOfWok( CompanyDbContext dbContext) //Ask For Object From DbContext
        { 
            EmployeeRepository=new EmployeeRepository(dbContext);
            DepartmentRepository=new DepartmentRepository(dbContext);
            this.dbContext = dbContext;
        }

        public async Task<int> Compelete()
       =>await dbContext.SaveChangesAsync();

        public void Dispose()
              => dbContext.Dispose();

    }
}
