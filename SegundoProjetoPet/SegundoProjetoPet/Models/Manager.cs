using System.Text.Json.Serialization;

namespace SegundoProjetoPet.Models
{
    public class Manager : Person
    {
        [JsonConstructor]
        public Manager(string name, string cpf, string email)
        {
            this.Name = name;
            this.Cpf = cpf;
            this.Email = email;
        }
    }
}