using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.piscis
{
    public abstract class Piscis : Craniata, Marine
    {
        protected Piscis(string? Name) : base(Name) 
        {
            Tail = true;
            Nose = false;
            Gill = true;
            Coating = "fish scales";
            PawType = "fin";
        }

        public abstract void Swim();
    }
}