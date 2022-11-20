using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.arthropoda.crustacean
{
    public abstract class Crustacean : Arthropoda, Marine, Omnivora
    {
        protected Crustacean(string Name) : base(Name)
        {
            Antenna = 4;
            Gill = true;
            Paws = 10;
            InferiorJaws = 2;
            SuperiorJaws = 2;
        }

        public abstract void Swim();

        public abstract override void Eat();
    }
}