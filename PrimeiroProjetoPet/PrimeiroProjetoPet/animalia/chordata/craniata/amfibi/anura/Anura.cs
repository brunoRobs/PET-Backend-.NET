using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.amfibi.anura
{
    public abstract class Anura : Amfibi, Quadruped, Venomous
    {
        protected Anura(string? Name) : base(Name)
        {
            Tail = false;
            Paws = 4;
            PawType = "leg";
        }

        public abstract void Croak();

        public abstract void Envenom();
    }
}