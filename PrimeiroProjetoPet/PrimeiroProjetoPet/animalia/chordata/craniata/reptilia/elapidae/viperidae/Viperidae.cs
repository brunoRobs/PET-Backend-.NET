using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.reptilia.elapidae.viperidae
{
    public abstract class Viperidae : Elapidae, Poisonous
    {
        protected Viperidae(string? Name) : base(Name) { }

        public abstract void Poison();
    }
}