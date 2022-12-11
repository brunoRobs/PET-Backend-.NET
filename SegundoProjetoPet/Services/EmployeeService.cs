using SegundoProjetoPet.Models;
using SegundoProjetoPet.Repositories;

namespace SegundoProjetoPet.Services
{
    public class EmployeeService : Service<Employee, EmployeeRepository>
    {
        public EmployeeService(EmployeeRepository repository) : base(repository) { }
    }
}