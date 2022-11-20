using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.mamalia
{
    public abstract class Mamalia : Craniata, Vivipara
    {
        public bool Pelage { get; protected set; }

        protected Mamalia(string? Name) : base(Name)
        {
            Paws = 4;
            Lungs = true;
            Coating = "skin";
        }

        public abstract void Breastfeed();
    }
}