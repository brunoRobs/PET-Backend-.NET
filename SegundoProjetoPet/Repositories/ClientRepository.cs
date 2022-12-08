using SegundoProjetoPet.Models;

namespace ExtensionList
{
    public static class RepositoryList
    {
        private static int GenerateId()
        {
            Random num = new Random();
            int id = num.Next();
            if (id < 0.0) return -1 * id;
            return id;
        }

        public static Client? GetClient(this List<Client> list, int id)
        {
            foreach (Client client in list)
            {
                if (client.Id == id) return client;
            }
            return null;
        }

        private static bool ContainId(this List<Client> list, int id)
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
            int newId = GenerateId();
            while (list.ContainId(newId))
            {
                newId = GenerateId();
            }
            client.Id = newId;
            list.Add(client);
            return true;
        }

        public static bool RemClient(this List<Client> list, int id)
        {
            return list.Remove(list.GetClient(id));
        }
        
        //Método que utilizei para visualizar lista de forma mais bonita aos olhos
        //Ler o json nos testes complicava desnecessariamente
        //public static string Members(this List<Client> list)
        //{
        //    string str = "";
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        str += list[i] + "\n\n"; 
        //    }
        //    return str;
        //}
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

        public bool Remove(int id)
        {
            return THEATHER_REGISTER.RemClient(id);
        }

        public Client? Get(int id) 
        {
            return THEATHER_REGISTER.GetClient(id);
        }

        public List<Client> Register()
        {
            return THEATHER_REGISTER;
        }
    }
}
