using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ReflectionActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;

        public ReflectionActivity(string name, string description)
            : base(name, description)
        {
            _prompts = new List<string>();
            _questions = new List<string>();
        }

        public void Run()
        {
            
        }

        private string GetRandomPrompt()
        {
            return ""; 
        }

        private string GetRandomQuestion()
        {
            return ""; 
        }
    }
}
