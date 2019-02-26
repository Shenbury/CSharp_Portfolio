using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returnStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Detailing the input+

            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);

            Console.ReadLine();
          

        }

        //Detailing what data to return
        static int cube(int num)
        {

            int result = num * num * num;
            return result;

        }
    
    }
}
