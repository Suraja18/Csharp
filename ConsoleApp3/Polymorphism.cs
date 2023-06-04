using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Pig says: wee wee");
        }
    }

    class Dog:Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Dogs Bark");
        }
    }


}
