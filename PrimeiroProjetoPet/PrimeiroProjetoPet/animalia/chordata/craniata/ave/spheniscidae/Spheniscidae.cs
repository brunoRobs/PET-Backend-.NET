using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.ave.spheniscidae
{
    public abstract class Spheniscidae : Ave, Marine, Biped, Karnivora
    {
        protected Spheniscidae(string? Name) : base(Name)
        {
            Paws = 4;
            PawType = "2 legs and fins";
        }

        public abstract void Swim();

        public abstract override void Eat();
    }
}