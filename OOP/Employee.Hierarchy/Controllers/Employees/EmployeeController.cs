using Employee.Hierarchy.Models.Employees;
using Employee.Hierarchy.Repository;
using Microsoft.AspNetCore.Mvc;
namespace Employee.Hierarchy.Controllers.Employees
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {
        private readonly Repository.Repository _repository;

        public EmployeeController(Repository.Repository repository)
        {
            _repository = repository;
        }


        /// <summary>
        /// Get All models stored into repository
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetEmployees()
        {
            return Ok(_repository.Employees);
        }

        [HttpGet("/{id}")]
        public ActionResult GetEmployeeById([FromRoute] int id)
        {
            return Ok(_repository.Employees);
        }


        /// <summary>
        /// Create and add into Repository Collection
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CreateHourPayEmployee(HourlyEmployee employee)
        {
            _repository.Employees.Add(employee);

            return Ok(true);
        }

        [HttpPost]
        public ActionResult CreateSalaryPayEmployee(SalariedEmployee employee)
        {
            _repository.Employees.Add(employee);

            return Ok(true);
        }
    }
}
