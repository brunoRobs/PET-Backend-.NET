namespace SegundoProjetoPet.Models
{
    public abstract class Person
    {
        public string Cpf { get; set; }

        private string Name { get; set; }

        protected Person(string name, string cpf)
        {
            this.Cpf = cpf;
            this.Name = name;
        }
    }
}