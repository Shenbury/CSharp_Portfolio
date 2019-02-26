using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementsAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            // Numbers to Compare
            Console.WriteLine(GetMax(20, 10, 40));

            Console.ReadLine();

        }


        // Comparing which number is greater
        static int GetMax(int num1, int num2, int num3)
        {

            int result;
            if (num1 >= num2 &&  num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;


        }
        
            

        

    }
}
