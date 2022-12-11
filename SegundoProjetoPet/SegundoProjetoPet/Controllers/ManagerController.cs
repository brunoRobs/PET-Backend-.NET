using Microsoft.AspNetCore.Mvc;
using SegundoProjetoPet.Models;
using SegundoProjetoPet.Repositories;
using SegundoProjetoPet.Services;

namespace SegundoProjetoPet.Controllers
{
    [Route("api/managers")]
    [ApiController]
    public class ManagerController : Controller<Manager, ManagerRepository, ManagerService>
    {
        public ManagerController() : base()
        {
            this.Service = new ManagerService(new ManagerRepository());
        }
    }
}