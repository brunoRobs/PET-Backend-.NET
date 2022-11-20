using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.reptilia.chelidae
{
    public abstract class Chelidae : Reptilia, Omnivora
    {
        public const bool Shell = true;

        protected Chelidae(string? Name) : base(Name)
        {
            Paws = 4;
        }

        public abstract void Retract();

        public abstract override void Eat();
    }
}