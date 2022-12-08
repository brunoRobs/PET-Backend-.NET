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

        public bool Remove(string cpf)
        {
            return Repository.Remove(cpf);
        }

        public bool Remove(ulong id)
        {
            return Repository.Remove(id);
        }

        public Client? Get(string cpf)
        {
            return Repository.Get(cpf);
        }

        public Client? Get(ulong id)
        {
            return Repository.Get(id);
        }

        public List<Client> Register()
        {
            return Repository.Register();
        }
    }
}