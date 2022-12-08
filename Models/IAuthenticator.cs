namespace SegundoProjetoPet.Models
{
    public interface IAuthenticator
    {
        bool Authenticate(string email, string password);
    }
}