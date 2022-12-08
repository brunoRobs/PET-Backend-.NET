using SegundoProjetoPet.Models;

namespace ExtensionList
{
    public static class RepositoryList
    {
        private static ulong GenerateId()
        {
            Random num = new Random();
            return (ulong)num.NextDouble();
        }

        public static Client? GetClient(this List<Client> list, ulong id)
        {
            foreach (Client client in list)
            {
                if (client.Id == id) return client;
            }
            return null;
        }

        public static Client? GetClient(this List<Client> list, string cpf)
        {
            foreach (Client client in list)
            {
                if (client.Cpf == cpf) return client;
            }
            return null;
        }

        private static bool ContainId(this List<Client> list, ulong id)
        {
            foreach (Client client in list)
            {
                if (client.Id == id) return true;
            }
            return false;
        }

        private static bool ContainCpf(this List<Client> list, string cpf)
        {
            foreach (Client client in list)
            {
                if (client.Cpf == cpf) return true;
            }
            return false;
        }

        public static bool AddClient(this List<Client> list, Client client)
        {
            if (list.ContainCpf(client.Cpf))
            {
                return false;
            }
            ulong newId = GenerateId();
            while (list.ContainId(newId))
            {
                newId = GenerateId();
            }
            client.Id = newId;
            list.Add(client);
            return true;
        }

        public static bool RemClient(this List<Client> list, ulong id)
        {
            return list.Remove(list.GetClient(id));
        }

        public static bool RemClient(this List<Client> list, string cpf)
        {
            return list.Remove(list.GetClient(cpf));
        }
    }
}

namespace SegundoProjetoPet.Repositories
{
    using ExtensionList;

    public class ClientRepository
    {
        private List<Client> THEATHER_REGISTER { get; }

        public ClientRepository()
        {
            THEATHER_REGISTER = new List<Client>();
            THEATHER_REGISTER.AddClient(new Client("fabio", "123", "fabinho@movie.com", "13579"));
            THEATHER_REGISTER.AddClient(new Client("rafa", "456", "rafinha@movie.com", "24680"));
            THEATHER_REGISTER.AddClient(new Client("conde", "789", "condido@movie.com", "12358"));
        }

        public bool Add(Client client)
        {
            return THEATHER_REGISTER.AddClient(client);
        }

        public bool Remove(string cpf)
        {
            return THEATHER_REGISTER.RemClient(cpf);
        }

        public bool Remove(ulong id)
        {
            return THEATHER_REGISTER.RemClient(id);
        }

        public Client? Get(string cpf) 
        {
            return THEATHER_REGISTER.GetClient(cpf);
        }

        public Client? Get(ulong id) 
        {
            return THEATHER_REGISTER.GetClient(id);
        }

        public List<Client> Register()
        {
            return THEATHER_REGISTER;
        }
    }
}