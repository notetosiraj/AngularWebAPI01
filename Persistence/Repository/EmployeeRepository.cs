using CRM01.Core;
using CRM01.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Owin.Security.Provider;
using System.Linq.Expressions;

namespace CRM01.Persistence.Repository
{
    public class EmployeeRepository : Repository<Employee> , IEmployeeRespository
    {
        public EmployeeRepository(CRMDbContext crmdbContext) :base(crmdbContext)
        { 
          
        }

        public IEnumerable<Employee> GetEmployeeByJoinDate(DateTime JoinDateFilter)
        {
            
            return getDBContext.Employee.Where(e => e.JoinDate >= JoinDateFilter && e.JoinDate <= JoinDateFilter);
        }

        public CRMDbContext getDBContext
        {
            get
            {
                return dbContext as CRMDbContext;  //this value retrieve from parent class
            }
        }
    }
}
