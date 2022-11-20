using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.ave.laridae
{
    public abstract class Laridae : Ave, Air, Omnivora
    {
        protected Laridae(string? Name) : base(Name)
        {
            Paws = 4;
            PawType = "2 legs and wings";
        }

        public abstract void Fly();

        public abstract override void Eat();
    }
}