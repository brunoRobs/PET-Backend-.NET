using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.mamalia.hominidae
{
    public abstract class Hominidae : Mamalia, Biped, Terrestris
    {
        protected Hominidae(string? Name) : base(Name)
        {
            Pelage = true;
            Nose = true;
            PawType = "2 legs and hands";
        }

        public abstract void Use();

        public abstract void Walk();
    }
}