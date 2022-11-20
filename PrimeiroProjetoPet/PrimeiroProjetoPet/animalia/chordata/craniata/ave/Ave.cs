using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.ave
{
    public abstract class Ave : Craniata, Terrestris, Biped, Ovipara
    {
        public const bool Feather = true;

        public const bool Beak = true;

        protected Ave(string? Name) : base(Name)
        {
            Tail = true;
            Nose = true;
            Lungs = true;
            Coating = "skin";
        }

        public abstract void BuildNest();

        public abstract void Walk();
    }
}