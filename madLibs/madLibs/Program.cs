using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring Variables
            string color, pluralNoun, celebrity;

            // Choosing string variables
            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            // Base story with Variables
            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love You " + celebrity);

            Console.ReadLine();
        }
    }
}
