using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore
{
    class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string Title, string Genre, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Genre = Genre;
            this.RunTime = RunTime;
            this.Scenes = new List<string>();
        }

        public override string ToString()
        {
            string output = $"Title: {Title}\n";
            output += $"Genre: {Genre}\n";
            output += $"Runtime: {RunTime}";
            return output;
        }

        public virtual void PrintScene()
        {
            for(int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i}: {Scenes[i]}");
            }
        }

        public virtual void Play()
        {

        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            return output;
        }
    }
}
