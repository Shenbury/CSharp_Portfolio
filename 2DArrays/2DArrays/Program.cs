using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid = {
            {1, 2 },
            {3, 4 },
            {5, 6 }
            };

            Console.WriteLine(numberGrid[1, 1]);

            Console.ReadLine();
        }
    }
}
