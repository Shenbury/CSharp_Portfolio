using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Default value of condition
            bool isMale = true;
            bool isTall = false;


            // Condition statement && both || either ! check for false
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            // Else if Condition statements
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are a tall female");
            }
            else if (!isMale && !isTall)
            {
                Console.WriteLine("You are a short female");
            }

            

                        
            Console.ReadLine();

        }
    }
}
