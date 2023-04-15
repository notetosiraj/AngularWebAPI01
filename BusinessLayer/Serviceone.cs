using CRM01.Core;
using CRM01.Core.Model;
using CRM01.Persistence.Repository;

namespace CRM01.BusinessLayer
{

    public interface IServiceone
    {
        IEnumerable<Employee> GetAllEmployees();
    }


    public class Serviceone : IServiceone
    {
        private IUnitOfWork unitOfWork;
        public Serviceone(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return unitOfWork.employeeRespository.GetAll();
        }


    }
}
