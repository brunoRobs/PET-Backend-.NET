using Microsoft.AspNetCore.Mvc;
using SegundoProjetoPet.Models;
using SegundoProjetoPet.Repositories;
using SegundoProjetoPet.Services;

namespace SegundoProjetoPet.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : Controller<Employee, EmployeeRepository, EmployeeService>
    {
        public EmployeeController() : base()
        {
            this.Service = new EmployeeService(new EmployeeRepository());
        }
    }
}