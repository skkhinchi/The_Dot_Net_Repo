using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_Api_App_Job_Portal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesDataController : ControllerBase
    {
        public string[] myEmployees = { "Sumit", "Ankit", "Madhur" };

       [HttpGet]
        public string[] GetEmployees()  
        {
            return myEmployees;
        }

        [Route("empDetails")]
        [HttpGet]
        public string GetEmployeeByIndex(int id)
        {
            return myEmployees[id];
        }
    }
}
