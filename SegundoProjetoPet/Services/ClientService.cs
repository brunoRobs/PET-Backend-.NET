using SegundoProjetoPet.Models;
using SegundoProjetoPet.Repositories;

namespace SegundoProjetoPet.Services
{
    public class ClientService : Service<Client, ClientRepository>
    {
        public ClientService(ClientRepository repository) : base(repository) { }
    }
}