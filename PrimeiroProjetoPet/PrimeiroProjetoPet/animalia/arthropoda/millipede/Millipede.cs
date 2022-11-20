using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.arthropoda.millipede
{
    public abstract class Millipede : Arthropoda, Herbivora
    {
        protected Millipede(string Name) : base(Name)
        {
            Paws = 100;
            PawsPerSegment = 4;
            Antenna = 2;
            InferiorJaws = 2;
            SuperiorJaws = 2;
        }

        public abstract void Stinky();

        public abstract void Curl();

        public abstract override void Eat();
    }
}