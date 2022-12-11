using System.Text.Json.Serialization;

namespace SegundoProjetoPet.Models
{
    public class Employee : Person
    {
        [JsonConstructor]
        public Employee(string name, string cpf, string email)
        {
            this.Name = name;
            this.Cpf = cpf;
            this.Email = email;
        }
    }
}