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
                this.Ok(new Message(10, "Succesfully added!"));
            }
            return this.Ok(new Message(11, "Client already existent."));
        }

        [HttpDelete("{cpf}")]
        public IActionResult Remove(string cpf)
        {
            if (service.Remove(cpf))
            {
                return this.Ok(new Message(20, "Succesfully excluded!"));
            }
            return this.Ok(new Message(21, "Client not found or already deleted."));
        }

        //[HttpDelete("{id}")]
        //public IActionResult Remove(double id)
        //{
        //    if (service.Remove(id))
        //    {
        //        return this.Ok(new Message(20, "Succesfully excluded!"));
        //    }
        //    return this.Ok(new Message(22, "Client not found or already deleted."));
        //}

        [HttpGet("{cpf}")]
        public IActionResult Get(string cpf)
        {
            Client? client = service.Get(cpf);
            if (client == null)
            {
                return this.Ok(new Message(23, "Client not found."));
            }
            return this.Ok(client);
        }

        //[HttpGet("{id}")]
        //public IActionResult Get(double id)
        //{
        //    Client? client = service.Get(id);
        //    if(client == null)
        //    {
        //        return this.Ok(new Message(24, "Client not found."));
        //    }
        //    return this.Ok(client);
        //}

        [HttpGet]
        public IActionResult Register()
        {
            return (IActionResult)service.Register();
        }
    }
}
