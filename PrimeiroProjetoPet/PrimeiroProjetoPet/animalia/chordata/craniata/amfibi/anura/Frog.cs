using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.amfibi.anura
{
    public class Frog : Anura
    {
        public Frog(string? Name) : base(Name) { }

        public override void Breath()
        {
            Console.WriteLine("Breathing...");
        }

        public override void Breed()
        {
            Console.WriteLine("Breeding...");
        }

        public override void Croak()
        {
            Console.WriteLine("Ribbit...");
        }

        public override void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public override void Interact()
        {
            Console.WriteLine("Interacting...");
        }

        public override void Jump()
        {
            Console.WriteLine("Jumping...");
        }

        public override void LookForFood()
        {
            Console.WriteLine("Looking...");
        }

        public override void See()
        {
            Console.WriteLine("Seeing...");
        }

        public override void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }

        public override void Communicate()
        {
            Console.WriteLine("Speaking...");
        }

        public override void Swim()
        {
            Console.WriteLine("Swimming...");
        }

        public override void Think()
        {
            Console.WriteLine("Thinking...");
        }

        public override void Envenom()
        {
            Console.WriteLine("Envenom...");
        }

        public override void Walk()
        {
            Console.WriteLine("Walking...");
        }

        public override void Metamorphosis()
        {
            Console.WriteLine("Changing...");
        }
    }
}