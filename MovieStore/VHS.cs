using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS (string Title, string Genre, int RunTime, List<string> Scenes) : base(Title,Genre,RunTime, Scenes)
        {
            this.CurrentTime = 0;
        }

        public override void Play()
        {            
            bool startPoint = true;

            while(startPoint)
            {
                
                try
                {
                    string sceneStart = Scenes[CurrentTime];
                    CurrentTime += 1;
                    Console.WriteLine($"Scene {CurrentTime}: {sceneStart}");
                    break;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Rewind();
                    startPoint = false;
                    continue;
                }
            }            
        }

        public bool RewindInput(string input)
        {
            string output = GetInput(input);
            
            if (output.ToLower() == "y")
            {
                return true;
            }
            else if (output.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please enter 'y' or 'n' to continue\n");
                return false;
            }
        }

        public void Rewind()
        {                        
            bool rewind = RewindInput("Would you like to rewind this tape? (Y or N)");

            if (rewind == true)
            {
                CurrentTime = 0;
                Console.WriteLine("Your movie has been rewound. You can now watch from the beginning\n");                
            }
        }
    }
}
