using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.reptilia.elapidae.boidae
{
    public abstract class Boidae : Elapidae
    {
        protected Boidae(string? Name) : base(Name) { }

        public abstract void Strangle();
    }
}