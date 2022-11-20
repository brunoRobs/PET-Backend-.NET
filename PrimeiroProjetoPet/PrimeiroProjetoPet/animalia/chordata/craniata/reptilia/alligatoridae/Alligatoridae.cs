using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.reptilia.alligatoridae
{
    public abstract class Alligatoridae : Reptilia, Marine, Karnivora
    {
        protected Alligatoridae(string? Name) : base(Name)
        {
            Paws = 4;
            PawType = "leg";
        }

        public abstract void Spin();

        public abstract void Swim();

        public abstract override void Eat();
    }
}