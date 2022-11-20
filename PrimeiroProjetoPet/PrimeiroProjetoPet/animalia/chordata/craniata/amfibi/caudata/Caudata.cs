using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.amfibi.caudata
{
    public abstract class Caudata : Amfibi, Quadruped, Venomous
    {
        protected Caudata(string? Name) : base(Name)
        {
            Tail = true;
            Paws = 4;
            PawType = "leg";
        }

        public abstract void Envenom();
    }
}