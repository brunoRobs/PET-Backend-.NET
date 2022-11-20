using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.arthropoda.arachnid
{
    public abstract class Arachnid : Arthropoda, Karnivora, Poisonous
    {
        public const uint Cheliceras = 2;

        public const uint Pedipalps = 2;

        protected Arachnid(string Name) : base(Name)
        {
            Paws = 8;
            Lungs = true;
        }

        public abstract void Poison();

        public override abstract void Eat();
    }
}