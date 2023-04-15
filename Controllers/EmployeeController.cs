using CRM01.BusinessLayer;
using CRM01.Core;
using CRM01.Core.Model;

using Microsoft.AspNetCore.Mvc;

namespace CRM01.Controllers
{     
    [ApiController]
    [Route("[controller]")]    
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private IServiceone serviceone;
        private IUnitOfWork unitOfWork;
        public EmployeeController(ILogger<EmployeeController> logger ,IUnitOfWork _unitOfWork, IServiceone _serviceone)
        {
            _logger = logger;
            _logger.LogInformation("EmployeeController constructor Test");
            unitOfWork = _unitOfWork;
            serviceone = _serviceone;
        }


        [HttpGet]
        public IEnumerable<int> Get()
        {
            return Enumerable.Range(1, 5)
            .ToArray();
        }


        [HttpGet("/GetAllEmp")]
        public IEnumerable<Employee> GetAllEmp()
        {
            return serviceone.GetAllEmployees();
        }
    }
}
