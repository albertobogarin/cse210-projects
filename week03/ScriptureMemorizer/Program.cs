using System;

class Program
{
    static void Main(string[] args)
    {
       
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";

        
        Scripture scripture = new Scripture(reference, text);

        
        int hideEachStep = 3;

        
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            Console.Write("> ");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
            {
                break;
            }

            
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("All words are hidden. Press Enter to finish.");
                Console.ReadLine();
                break;
            }

            
            scripture.HideRandomWords(hideEachStep);
        }
    }
}

