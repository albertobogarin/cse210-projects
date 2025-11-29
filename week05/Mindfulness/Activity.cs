using System;
using System.Threading;

namespace Mindfulness
{
    public class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration; // seconds

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
            _duration = 0;
        }

        public void SetDuration(int seconds)
        {
            if (seconds < 0) seconds = 0;
            _duration = seconds;
        }

        public int GetDuration()
        {
            return _duration;
        }

        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"*** {_name} ***");
            Console.WriteLine();
            Console.WriteLine(_description);
            Console.WriteLine();
            Console.Write("Enter duration in seconds: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int seconds))
            {
                seconds = 0;
            }
            SetDuration(seconds);

            Console.WriteLine();
            Console.WriteLine("Get ready...");
            ShowCountDown(3);
            Console.Clear();
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!");
            ShowSpinner(2);
            Console.WriteLine($"You have completed {_name} for {_duration} seconds.");
            ShowSpinner(2);
            Console.WriteLine();
            Console.WriteLine("Press Enter to return to the menu...");
            Console.ReadLine();
        }

        // simple spinner animation for x seconds
        public void ShowSpinner(int seconds)
        {
            string[] sequence = { "|", "/", "-", "\\" };
            DateTime end = DateTime.Now.AddSeconds(seconds);
            int i = 0;
            while (DateTime.Now < end)
            {
                Console.Write(sequence[i % sequence.Length]);
                Thread.Sleep(300);
                Console.Write("\b \b");
                i++;
            }
        }

        // countdown from value to 1 with numbers
        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i >= 1; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }
    }
}

