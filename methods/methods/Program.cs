using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method inclusion in Main
            SayHi("Mike", 33);
            SayHi("John", 56);
            SayHi("Tom", 21);

            Console.ReadLine();
                    
        }

        //Method Information
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

    }
}
