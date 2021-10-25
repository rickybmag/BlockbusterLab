using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MovieStore
{
    class Blockbuster
    {
        public List<Movie> Movies = new List<Movie>();

        public Blockbuster()
        {
            List<string> scenes = new List<string>() { "Start", "First Act", "Second Act", "Third Act", "Fourth Act", "Credits" };
            Movies.Add(new VHS("Halloween", "Horror", 102, scenes));
            Movies.Add(new VHS("Total Recall", "Action", 113, scenes));
            Movies.Add(new VHS("Stepmom", "Drama", 125, scenes));
            Movies.Add(new DVD("The Wedding Singer", "Comedy", 102, scenes));
            Movies.Add(new DVD("her", "Romance", 126, scenes));
            Movies.Add(new DVD("Cobra", "Action", 87, scenes));
        }

        public void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {Movies[i].Title}");
            }
        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            return output;
        }

        public Movie Checkout()
        {            
            PrintMovies();

            string input;
            int movieNumber;
            
            Movie movie;

            bool rent = true;

            while(rent)
            {

                input = GetInput("Please select a movie to watch");
                movieNumber = int.Parse(input);

                try
                {
                    if (movieNumber > 0 && movieNumber <= Movies.Count)
                    {
                        movie = Movies.ToList()[movieNumber];
                        return movie;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That's not a movie. Please try again");
                    continue;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Please enter a number between 1 and {Movies.Count}");
                    continue;
                }
            }
            return Checkout(); 
        }

        public bool ContinueWatching(string prompt)
        {            
                string input = GetInput(prompt);

                if(input.ToLower() == "y")
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

        public void PlayMovie(Movie input)
        {
            Console.WriteLine(input);
            Console.WriteLine();
            bool view = ContinueWatching("Would you like to watch this movie? (Y or N)");

            while (view)
            {
                input.Play();
                view = ContinueWatching("Would you like to watch another scene? (Y or N)");
            }
        }


    }
}
