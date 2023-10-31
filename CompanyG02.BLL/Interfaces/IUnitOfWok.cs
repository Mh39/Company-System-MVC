using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyG02.BLL.Interfaces
{
    public interface IUnitOfWok: IDisposable
    {
        IEmployeeRepository EmployeeRepository { get; set; }
        IDepartmentRepository DepartmentRepository {  get; set; }
        Task<int> Compelete();
        
    }
}
