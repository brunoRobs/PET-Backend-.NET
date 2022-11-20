using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.mamalia.felidae
{
    public abstract class Felidae : Mamalia, Quadruped, Terrestris, Karnivora
    {
        protected Felidae(string? Name) : base(Name)
        {
            Pelage = true;
            Nose = true;
            Tail = true;
            PawType = "leg";
        }

        public abstract override void Eat();

        public abstract void Purr();

        public abstract void Sniff();

        public abstract void Walk();
    }
}