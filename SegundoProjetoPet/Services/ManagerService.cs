using SegundoProjetoPet.Models;
using SegundoProjetoPet.Repositories;

namespace SegundoProjetoPet.Services
{
    public class ManagerService : Service<Manager, ManagerRepository>
    {
        public ManagerService(ManagerRepository repository) : base(repository) { }
    }
}