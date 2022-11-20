using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.reptilia.chamaeleonidae
{
    public abstract class Chamaeleonidae : Reptilia, Karnivora
    {
        protected Chamaeleonidae(string? Name) : base(Name)
        {
            Paws = 4;
            PawType = "leg";
        }

        public abstract void Camouflage();

        public abstract override void Eat();
    }
}