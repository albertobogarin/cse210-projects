using System;
using System.Collections.Generic;

// W07 Exercise Tracking Program
// This program demonstrates inheritance and polymorphism.

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 4.8));  // 4.8 km run
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 45, 20));   // 20 kph
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 25, 40));  // 40 laps

        // Display summary for each
        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}
