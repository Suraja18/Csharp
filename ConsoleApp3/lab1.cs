using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class lab1
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();
            Console.WriteLine("Hello this is CSharp Class");
            //WriteLine Print the line in nextline.
            Console.Write("Lets Learn Something New.");
            Console.Write("Lets Learn Something old");
            Console.WriteLine();

            //Read Line input by user
            Console.Write("Write Something: ");
            Console.WriteLine(Console.ReadLine());
      
        } 
    }
}
