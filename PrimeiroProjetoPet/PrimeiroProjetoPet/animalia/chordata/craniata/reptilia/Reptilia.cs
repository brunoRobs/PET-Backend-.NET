using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.reptilia
{
    public abstract class Reptilia : Craniata, Terrestris, Ovipara
    {
        protected Reptilia(string? Name) : base(Name) 
        {
            Tail = true;
            Nose = true;
            Lungs = true;
            Coating = "scales";
        }

        public abstract void Walk();
    }
}