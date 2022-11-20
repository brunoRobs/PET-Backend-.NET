using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.piscis.osteichthye
{
    public abstract class Osteichthye : Piscis, Omnivora, Ovipara
    {
        public const string SkeletonType = "bones";

        protected Osteichthye(string? Name) : base(Name) { }

        public override abstract void Eat();
    }
}