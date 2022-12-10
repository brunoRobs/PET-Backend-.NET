using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SegundoProjetoPet.Models;
using SegundoProjetoPet.Services;

namespace SegundoProjetoPet.Controllers
{
    [Route("api/client")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private static ClientService service = new ClientService(new Repositories.ClientRepository());

        [HttpPost]
        public IActionResult Add(Client client)
        {
            if (service.Add(client))
            {
                return this.Ok(new Message(10, "Succesfully added!"));
            }
            return this.Ok(new Message(11, "Client already existent or invalid CPF."));
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            if (service.Remove(id))
            {
                return this.Ok(new Message(20, "Succesfully excluded!"));
            }
            return this.Ok(new Message(22, "Client not found or already deleted."));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Client? client = service.Get(id);
            if(client == null)
            {
                return this.Ok(new Message(24, "Client not found."));
            }
            return this.Ok(client);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return this.Ok(service.Register());
        }
    }
}
