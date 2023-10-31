using CompanyG02.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyG02.BLL.Interfaces
{
    public interface IEmployeeRepository:IGenericRepository<Employee>
    {
        public IQueryable<Employee> GetEmployeesByAdress(string Adress);
        public IQueryable <Employee> GetEmpByName(string Name);
        #region MyRegion

        //IEnumerable<Employee> GetAll();
        //Employee Get(int id);
        //int Add(Employee employee);
        //int Update(Employee employee);
        //int Delete(Employee employee);
        #endregion
    }
}
