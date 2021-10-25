using System;
using System.Collections.Generic;

namespace MovieStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster rental = new Blockbuster();
            bool keepGoing = true;            

            while (keepGoing)
            {
                Console.WriteLine("Welcome to Blockbuster");
                Movie view = rental.Checkout();
                view.Play();                
            }

            keepGoing = rental.ContinueWatching("Would you like to watch another movie? (Y or N)");

            Console.WriteLine("Goodbye");
        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            return output;
        }

        public bool ContinueWatching(string prompt)
        {
            string input = GetInput(prompt);

            if (input.ToLower() == "y")
            {
                return true;
            }
            else if (input.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please enter 'y' to continue watching or 'n' to quit");
                return false;
            }
        }
    }
}
