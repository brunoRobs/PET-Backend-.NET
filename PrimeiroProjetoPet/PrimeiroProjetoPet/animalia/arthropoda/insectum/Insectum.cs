using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.arthropoda.insectum
{
    public abstract class Insectum : Arthropoda, Omnivora
    {
        protected Insectum(string Name) : base(Name)
        {
            Eyes = 2;
            Paws = 6;
            Antenna = 2;
        }

        public abstract override void Eat();
    }
}