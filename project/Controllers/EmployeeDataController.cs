using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDataController : ControllerBase
    {
        public EmployeeDataController()
        {
            
        }
        private readonly IEmployeeBusiness _EmployeeBusiness;
        public EmployeeDataController(IEmployeeBusiness EmployeeBusiness)
        {
            _EmployeeBusiness = EmployeeBusiness;
        }

        [HttpGet()]
        public IEnumerable<EmployeeS> Getemployee()
        {
            var result = _EmployeeBusiness.GetEmployee();
            return result;
        }
    }
}
      
    

