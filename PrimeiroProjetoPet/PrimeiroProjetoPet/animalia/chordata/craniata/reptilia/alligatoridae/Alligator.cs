using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPet.animalia.chordata.craniata.reptilia.alligatoridae
{
    public class Alligator : Alligatoridae
    {
        public Alligator(string? Name) : base(Name) { }

        public override void Breath()
        {
            Console.WriteLine("Brathing...");
        }

        public override void Breed()
        {
            Console.WriteLine("Breeding...");
        }

        public override void Spin()
        {
            Console.WriteLine("Spinning...");
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

        public override void Think()
        {
            Console.WriteLine("Thinking...");
        }

        public override void Walk()
        {
            Console.WriteLine("Walking...");
        }

        public override void Swim()
        {
            Console.WriteLine("Swimming...");
        }
    }
}