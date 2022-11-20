using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.ave.apterygidae
{
    public abstract class Apterygidae : Ave, Omnivora
    {
        protected Apterygidae(string? Name) : base(Name) 
        {
            Paws = 2;
            PawType = "leg";
        }

        public override abstract void Eat();
    }
}