using System.Text.Json.Serialization;

namespace SegundoProjetoPet.Models
{
    public class Client : Person
    {
        [JsonConstructor]
        public Client(string name, string cpf, string email)
        {
            this.Name = name;
            this.Cpf = cpf;
            this.Email = email;
        }
    }
}