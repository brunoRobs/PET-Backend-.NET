using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.reptilia.elapidae
{
    public abstract class Elapidae : Reptilia, Marine, Karnivora
    {
        protected Elapidae(string? Name) : base(Name)
        {
            Paws = 0;
        }

        public abstract void Swim();

        public abstract override void Eat();
    }
}