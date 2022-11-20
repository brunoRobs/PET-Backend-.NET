using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.piscis.condricte
{
    public abstract class Condricte : Piscis, Karnivora, Vivipara
    {
        public const string SkeletonType = "cartilage";

        protected Condricte(string? name) : base(name) { }

        public override abstract void Eat();
    }
}