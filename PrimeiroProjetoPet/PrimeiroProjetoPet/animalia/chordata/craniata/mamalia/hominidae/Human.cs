using PrimeiroProjetoPet.animalia.chordata.craniata.mamalia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.mamalia.hominidae
{
    public class Human : Hominidae, Omnivora
    {
        public Human(string? Name) : base(Name) { }

        public override void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public override void Communicate()
        {
            Console.WriteLine("Speaking...");
        }

        public override void See()
        {
            Console.WriteLine("Seeing...");
        }

        public override void Breath()
        {
            Console.WriteLine("Breathing...");
        }

        public override void Breed()
        {
            Console.WriteLine("Breeding...");
        }

        public override void Think()
        {
            Console.WriteLine("Thinking...");
        }

        public override void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }

        public override void LookForFood()
        {
            Console.WriteLine("Looking...");
        }

        public override void Jump()
        {
            Console.WriteLine("Jumping...");
        }

        public override void Breastfeed()
        {
            Console.WriteLine("Breastfeeding...");
        }

        public override void Interact()
        {
            Console.WriteLine("Interacting...");
        }

        public override void Use()
        {
            Console.WriteLine("Using something...");
        }

        public override void Walk()
        {
            Console.WriteLine("Walking...");
        }

        public void Craft()
        {
            Console.WriteLine("Crafting something...");
        }

        public void Read()
        {
            Console.WriteLine("Reading...");
        }
    }
}