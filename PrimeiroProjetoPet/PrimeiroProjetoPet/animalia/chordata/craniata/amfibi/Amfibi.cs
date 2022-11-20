using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.amfibi
{
    public abstract class Amfibi : Craniata, Terrestris, Marine, Metamorpho, Karnivora, Ovipara
    {
        protected Amfibi(string? Name) : base(Name)
        {
            Nose = true;
            Lungs = true;
            Coating = "skin";
        }

        public abstract void Walk();

        public abstract void Swim();

        public abstract void Metamorphosis();

        public abstract override void Eat();
    }
}