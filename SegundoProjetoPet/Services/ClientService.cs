using SegundoProjetoPet.Models;
using SegundoProjetoPet.Repositories;

namespace SegundoProjetoPet.Services
{
    public class ClientService
    {
        private ClientRepository Repository { get; }

        public ClientService(ClientRepository repository)
        {
            Repository = repository;
        }

        public bool Add(Client client)
        {
            return Repository.Add(client);
        }

        public bool Remove(int id)
        {
            return Repository.Remove(id);
        }

        public Client? Get(int id)
        {
            return Repository.Get(id);
        }

        public string Register()
        {
            return Repository.Register();
        }
    }
}
