using CRM01.Core;

namespace CRM01.Persistence.Repository
{
    public class UnitOfWork :IUnitOfWork
    {
        private CRMDbContext cRMDbContext;
        public UnitOfWork(CRMDbContext _cRMDbContext)
        {
            cRMDbContext = _cRMDbContext;
            employeeRespository = new EmployeeRepository(_cRMDbContext);
        }

        public IEmployeeRespository employeeRespository { get; set; }

        public int Complete()
        {
          return  cRMDbContext.SaveChanges();
        }
    }
}
