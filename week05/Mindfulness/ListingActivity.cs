using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts;
        private Random _rnd;

        public ListingActivity() : base("Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
            _rnd = new Random();
            _prompts = new List<string>()
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
        }

        private string GetRandomPrompt()
        {
            int idx = _rnd.Next(_prompts.Count);
            return _prompts[idx];
        }

        public void Run()
        {
            DisplayStartingMessage();

            string prompt = GetRandomPrompt();
            Console.WriteLine("List as many responses as you can to the following prompt:");
            Console.WriteLine($"--- {prompt} ---");
            Console.WriteLine();
            Console.WriteLine("You may begin in:");
            ShowCountDown(5);

            List<string> responses = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string line = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(line))
                {
                    responses.Add(line.Trim());
                }
            }

            Console.WriteLine();
            Console.WriteLine($"You listed {responses.Count} items!");
            DisplayEndingMessage();
        }
    }
}


