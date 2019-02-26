using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run getAppInfo function

            //Ask Users Name
            Console.WriteLine("What is your name?");

            // Get User Input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game ...", inputName);

            while (true)
            {             
            // Init correct number

            //Create a new random number
            Random random = new Random();

            int correctNumber = random.Next(1,10);

            //Init guess var
            int guess = 0;

            //Ask user for number
            Console.WriteLine("Guess a number between 1 and 10!");

            while (guess != correctNumber)
            {
                //Get User Input
                string input = Console.ReadLine();

                // Check if number
                if(!int.TryParse(input, out guess))
                {

                    //Change Text Color
                    Console.ForegroundColor = ConsoleColor.Magenta;

                    // Tell user they failed
                    Console.WriteLine("{0} that is not a number! ", inputName);

                    //Reset Text Color
                    Console.ResetColor();

                    //Keep Going
                    continue;


                }

                //Cast to into and put in guess
                guess = Int32.Parse(input);

                //Match guess to correct number
                if (guess != correctNumber)
                {
                    //Change Text Color
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    // Tell user they failed
                    Console.WriteLine("{0} You have failed!! I will grant you another attempt!", inputName);

                    //Reset Text Color
                    Console.ResetColor();
                }

            }

                  //Output Success Message

                  //Change Text Color
                  Console.ForegroundColor = ConsoleColor.Yellow;

                 // Tell user they have passed
                 Console.WriteLine("{0} You have passed my test CONGRATULATIONS!", inputName);

                 //Reset Text Color
                 Console.ResetColor();

                //Ask to play again
                Console.WriteLine("{0} do you want to play again? [Y OR N]");

                //Get Answer
                string answer = Console.ReadLine().ToUpper();

                if (answer =="Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }

                //Hold App Until Returned
                Console.ReadLine();
            }

        }

        //App Info Function
        static void GetAppInfo() 
        {
            //Set App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Simon Henbury";

            //Change Text Color
            Console.ForegroundColor = ConsoleColor.Blue;

            // Write out App Info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset Text Color
            Console.ResetColor();
        }

    }
}
