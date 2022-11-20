using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.mamalia.canidae
{
    public abstract class Canidae : Mamalia, Quadruped, Terrestris, Karnivora
    {
        protected Canidae(string? Name) : base(Name)
        {
            Pelage = true;
            Nose = true;
            Tail = true;
            PawType = "leg";
        }

        public abstract override void Eat();

        public abstract void Howl();

        public abstract void Sniff();

        public abstract void Walk();
    }
}
