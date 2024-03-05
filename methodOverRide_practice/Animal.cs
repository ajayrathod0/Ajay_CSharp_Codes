using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverRide_practice
{
    public class Animal
    {
        public virtual void AnimalSound()
        {

            Console.WriteLine("The Animal makes a Sound");
        }
    }

    public class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The Pig says : wee wee");
        }
    }
    public class Dog : Animal
    {

        public override void AnimalSound()
        {
            Console.WriteLine("The Dog says : bow bow");
        }
    }

    public class Cat : Dog
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The Cat says : meow meow");
        }

    }
}
