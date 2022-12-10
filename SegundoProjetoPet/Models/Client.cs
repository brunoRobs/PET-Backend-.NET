namespace SegundoProjetoPet.Models
{
    public class Client : ISystem, IAuthenticator
    {
        public string? Name { get; set; }

        public string? Cpf { get; set; }

        public int Id { get; set; }

        public string? Email { get; set; }

        private string? Password { get; set; }

        public override string ToString()
        {
            return $"Name: {this.Name}\nCPF: {this.Cpf}\nId: {this.Id}\nEmail: {this.Email}";
        }
        
        public Client()
        {
            
        }

        public Client(string name, string cpf, string email, string password)
        {
            this.Name = name;
            this.Cpf = cpf;
            this.Email = email;
            this.Password = password;
        }

        public bool Authenticate(string email, string password)
        {
            return this.Email == email && this.Password == password;
        }
    }
}
