namespace SegundoProjetoPet.Models
{
    public abstract class Person : ISystem
    {
        public string? Name { get; set; }

        public string? Cpf { get; set; }

        public int Id { get; set; }

        public string? Email { get; set; }
    }
}