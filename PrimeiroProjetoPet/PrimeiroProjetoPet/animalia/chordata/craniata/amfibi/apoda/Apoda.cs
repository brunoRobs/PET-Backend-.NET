using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.amfibi.apoda
{
    public abstract class Apoda : Amfibi, Poisonous
    {
        protected Apoda(string? Name) : base(Name)
        {
            Tail = true;
            Paws = 0;
        }

        public abstract void Burry();

        public abstract void Poison();
    }
}