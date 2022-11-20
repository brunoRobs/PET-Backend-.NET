using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata
{
    public abstract class Craniata : Chordata
    {
        public bool Tail { get; protected set; }

        public bool Nose { get; protected set; }

        public const bool Skeleton = true;

        protected Craniata(string? name) : base(name) 
        {
            Eyes = 2;
        }
    }
}