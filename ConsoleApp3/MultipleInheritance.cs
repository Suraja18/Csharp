using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface Apple
    {
        void color();
    }
    interface Mango
    {
        void taste();
    }
    class MultipleInheritance : Apple, Mango 
    {
        public void color()
        {
            Console.WriteLine("Apple Color Red");
        }
        public void taste()
        {
            Console.WriteLine("Mango Taste Goods");
        }
    }

}
