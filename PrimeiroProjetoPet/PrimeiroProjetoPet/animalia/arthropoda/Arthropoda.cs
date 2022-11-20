using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.arthropoda
{
    public abstract class Arthropoda : Animal, Terrestris, Ovipara
    {
        public const bool Symmetry = true;

        public const bool Segmentation = true;

        public const bool Hemolymph = true;

        public uint Antenna { get; protected set; }

        public uint PawsPerSegment { get; protected set; }

        public uint InferiorJaws { get; protected set; }

        public uint SuperiorJaws { get; protected set; }

        protected Arthropoda(string Name) : base(Name)
        {
            PawType = "hinged appendage";
            Coating = "exoskeleton";
        }

        public abstract void Ecdysis();

        public abstract void Walk();
    }
}