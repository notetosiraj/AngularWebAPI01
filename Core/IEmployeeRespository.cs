using CRM01.Core.Model;

namespace CRM01.Core
{
    public interface IEmployeeRespository :IRepository<Employee>
    {
      IEnumerable<Employee> GetEmployeeByJoinDate(DateTime JoinDateFilter);
    }
}
