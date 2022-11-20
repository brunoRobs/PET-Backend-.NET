using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.arthropoda.chilopod
{
    public abstract class Chilopod : Arthropoda, Karnivora, Poisonous
    {
        protected Chilopod(string Name) : base(Name)
        {
            Paws = 200;
            PawsPerSegment = 2;
            Antenna = 2;
            SuperiorJaws = 4;
            InferiorJaws = 2;
        }

        public abstract override void Eat();

        public abstract void Poison();
    }
}