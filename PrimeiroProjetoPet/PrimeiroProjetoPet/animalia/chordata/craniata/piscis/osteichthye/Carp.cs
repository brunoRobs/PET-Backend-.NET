using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.piscis.osteichthye
{
    public class Carp : Osteichthye
    {
        public Carp(string? Name) : base(Name)
        {
            Paws = 7;
        }

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

        public override void Interact()
        {
            Console.WriteLine("Interacting...");
        }

        public override void Swim()
        {
            Console.WriteLine("Swimming...");
        }
    }
}