using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading the first number
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            //Reading the second number
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //Math Equation 
            Console.WriteLine(num1 + num2);

            //Reading the Code
            Console.ReadLine();

        }
    }
}
