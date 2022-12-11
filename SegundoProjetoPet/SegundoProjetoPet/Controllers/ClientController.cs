using Microsoft.AspNetCore.Mvc;
using SegundoProjetoPet.Models;
using SegundoProjetoPet.Repositories;
using SegundoProjetoPet.Services;

namespace SegundoProjetoPet.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientController : Controller<Client, ClientRepository, ClientService>
    {
        public ClientController() : base()
        {
            this.Service = new ClientService(new ClientRepository());
        }
    }
}