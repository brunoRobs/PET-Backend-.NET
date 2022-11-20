using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata
{
    public abstract class Chordata : Animal
    {
        public const bool Notochord = true;

        public const bool Blood = true;

        protected Chordata(string? name) : base(name) 
        {
            Vertebrate = true;
        }
    }
}