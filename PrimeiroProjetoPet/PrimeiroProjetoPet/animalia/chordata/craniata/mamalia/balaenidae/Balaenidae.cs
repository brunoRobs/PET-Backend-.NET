using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.mamalia.balaenidae
{
    public abstract class Balaenidae : Mamalia, Quadruped, Marine, Karnivora
    {
        public const bool Respirator = true;

        protected Balaenidae(string? Name) : base(Name)
        {
            Tail = true;
            PawType = "fin";
        }

        public abstract void Swim();

        public abstract override void Eat();
    }
}