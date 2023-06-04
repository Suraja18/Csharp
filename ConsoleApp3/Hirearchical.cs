using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ParentClass
    {
        public string Name;
        public int Id = 9;
        public void displayParentClassDetails()
        {
            Console.WriteLine($"I am {Name}");
            Console.WriteLine($"ID : {Id}");
        }
    }
    class ChildClass : ParentClass
    {
        public void getIdFromParentClass()
        {
            Console.WriteLine("Displaying From my Child Class");
            Console.WriteLine($"This is my ID: {Id}.");
        }
    }
    class AnotherChildClass : ParentClass 
    {
        public void getIdFromParentClass()
        {
            Console.WriteLine("Displaying From my Other Child Class");
            Console.WriteLine($"This is my ID: {Id}.");
        }
    }
}
