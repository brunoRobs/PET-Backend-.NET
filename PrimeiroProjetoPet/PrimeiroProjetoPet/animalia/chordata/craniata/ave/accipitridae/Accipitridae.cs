using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.ave.accipitridae
{
    public abstract class Accipitridae : Ave, Air, Karnivora
    {
        protected Accipitridae(string? Name) : base(Name)
        {
            Paws = 4;
            PawType = "2 legs and wings";
        }

        public abstract void Fly();

        public override abstract void Eat();
    }
}