using System;

namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Program");
                Console.WriteLine("-------------------");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        var breathing = new BreathingActivity();
                        breathing.Run();
                        break;
                    case "2":
                        var reflecting = new ReflectionActivity();
                        reflecting.Run();
                        break;
                    case "3":
                        var listing = new ListingActivity();
                        listing.Run();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Press Enter to try again...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}

