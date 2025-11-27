using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts;

        public ListingActivity(string name, string description)
            : base(name, description)
        {
            
            _prompts = new List<string>()
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt grateful recently?",
                "What accomplishments are you proud of?"
            };
        }

        public void Run()
        {
            
            DisplayStartingMessage();

            Console.WriteLine();
            Console.WriteLine("List as many responses as you can to the following prompt:");
            string prompt = GetRandomPrompt();
            Console.WriteLine($" --- {prompt} --- ");
            Console.WriteLine("You may begin in:");
            ShowSpinner(3); 

            
            List<string> responses = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string? input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    responses.Add(input);
                }
            }

            Console.WriteLine();
            Console.WriteLine($"You listed {responses.Count} items!");

            
            DisplayEndingMessage();
        }

        private string GetRandomPrompt()
        {
            var rnd = new Random();
            int index = rnd.Next(_prompts.Count);
            return _prompts[index];
        }
    }
}

