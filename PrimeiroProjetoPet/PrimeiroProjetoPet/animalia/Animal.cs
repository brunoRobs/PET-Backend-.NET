using PrimeiroProjetoPet.animalia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia
{
    interface Karnivora
    {
        void Eat();
    }

    interface Herbivora
    {
        void Eat();
    }
    
    interface Omnivora
    {
        void Eat();
    }

    interface Marine
    {
        void Swim();
    }

    interface Terrestris
    {
        void Walk();
    }

    interface Air
    {
        void Fly();
    }

    interface Poisonous
    {
        void Poison();
    }

    interface Venomous
    {
        void Envenom();
    }

    interface Biped
    {
        const bool biped = true;
    }

    interface Quadruped
    {
        const bool quadruped = true;
    }

    interface Metamorpho
    {
        const bool GillsInYouth = true;

        void Metamorphosis();
    }

    interface Ovipara
    {
        const bool EggDevelopment = true;
    }

    interface Vivipara
    {
        const bool InternalDevelopment = true;
    }

    public abstract class Animal
    {
        public string? Name { get; protected set; }

        public string Coating { get; protected set; } = string.Empty;

        public uint Paws { get; protected set; }

        public string? PawType { get; protected set; }

        public uint Eyes { get; protected set; }

        public bool Vertebrate { get; protected set; }

        public bool Lungs { get; protected set; }

        public bool Gill { get; protected set; }

        protected Animal(string? name)
        {
            Name = name;
        }

        public abstract void Eat();

        public abstract void Communicate();

        public abstract void See();

        public abstract void Breath();

        public abstract void Breed();

        public abstract void Think();

        public abstract void Sleep();

        public abstract void LookForFood();

        public abstract void Jump();

        public abstract void Interact();
    }
}