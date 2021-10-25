using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore
{
    class DVD : Movie
    {
        public DVD(string Title, string Genre, int RunTime, List<string> Scenes) : base (Title, Genre, RunTime, Scenes)
        {

        }

        public override void Play()
        {
            string prompt = GetInput($"Which point in the your movie would you like to start watching from? Please select a number from 1 to 6");
            int sceneStart = int.Parse(prompt);

            bool start = true;

            while (start)
            {
                try
                {
                    if (sceneStart >= 1 && sceneStart <= 6)
                    {
                        break;
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine($"Please enter a number between 1 and 6 to start watching from a scene");
                    continue;
                }
                catch(ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Pleaes try entering a number again");
                    continue;
                }

                string startPoint = Scenes[sceneStart];
                Console.WriteLine($"Scene {sceneStart}: {startPoint}");
            }
        }

        public void PlayEntireMovie()
        {
            {
                for (int i = 0; i < Scenes.Count; i++)
                {
                    Console.WriteLine($"Scene {i}: {Scenes[i]}");
                }
            }
        }
    }
}
