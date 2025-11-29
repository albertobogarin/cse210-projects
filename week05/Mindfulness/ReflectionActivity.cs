using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ReflectionActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;
        private Random _rnd;

        public ReflectionActivity() : base("Reflection Activity",
            "This activity will help you reflect on times when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {
            _rnd = new Random();
            _prompts = new List<string>()
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            _questions = new List<string>()
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
        }

        private string GetRandomPrompt()
        {
            int idx = _rnd.Next(_prompts.Count);
            return _prompts[idx];
        }

        private string GetRandomQuestion()
        {
            int idx = _rnd.Next(_questions.Count);
            return _questions[idx];
        }

        public void Run()
        {
            DisplayStartingMessage();

            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine($"--- {GetRandomPrompt()} ---");
            Console.WriteLine();
            Console.WriteLine("When you are ready, press Enter to continue.");
            Console.ReadLine();

            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                string q = GetRandomQuestion();
                Console.WriteLine();
                Console.WriteLine($"> {q}");
                // pause and spinner for reflection
                ShowSpinner(5);
                Console.WriteLine();
            }

            DisplayEndingMessage();
        }
    }
}

