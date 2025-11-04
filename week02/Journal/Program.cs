using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal myJournal = new Journal();
        Entry testEntry = new Entry();
        testEntry.Display();

        Console.WriteLine("Program executed successfully!");
    }
}
