namespace SegundoProjetoPet.Models
{
    public class Client : Person, ISystem, IAuthenticator
    {
        public double Id { get; set; }

        public string Email { get; set; }

        private string Password { get; set; }

        public Client(string name, string cpf, string email, string password) : base(name, cpf)
        {
            this.Email = email;
            this.Password = password;
        }

        public bool Authenticate(string email, string password)
        {
            return this.Email == email && this.Password == password;
        }
    }
}
