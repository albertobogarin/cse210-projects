using System;

namespace Mindfulness
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity(string name, string description)
            : base(name, description)
        {
        }

        public void Run()
        {
            
            DisplayStartingMessage();

            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Breathe in...");
                
                ShowSpinner(4);

                Console.WriteLine("Breathe out...");
                
                ShowSpinner(6);
            }

        
            DisplayEndingMessage();
        }
    }
}

