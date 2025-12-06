using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void MainMenu()
    {
        int option = 0;

        while (option != 6)
        {
            Console.WriteLine("\n===== Eternal Quest =====");
            Console.WriteLine($"Current Score: {_score}");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Choose an option: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoals(); break;
                case 3: SaveGoals(); break;
                case 4: LoadGoals(); break;
                case 5: RecordGoalEvent(); break;
                case 6: Console.WriteLine("Goodbye!"); break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nChoose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        int type = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == 3)
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    private void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        foreach (Goal g in _goals)
        {
            Console.WriteLine(g.GetDetailsString());
        }
    }

    private void SaveGoals()
    {
        Console.Write("Enter filename: ");
        string file = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(file))
        {
            sw.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                sw.WriteLine(g.GetStringRepresentation());
            }
        }

        Console.WriteLine("Saved!");
    }

    private void LoadGoals()
    {
        Console.Write("Enter filename: ");
        string file = Console.ReadLine();

        string[] lines = File.ReadAllLines(file);

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                var g = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));

               
                if (bool.Parse(parts[4]))
                    g.RecordEvent();

                _goals.Add(g);
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (type == "ChecklistGoal")
            {
                var g = new ChecklistGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[4]),
                    int.Parse(parts[6])
                );

                
                int count = int.Parse(parts[5]);
                for (int j = 0; j < count; j++)
                    g.RecordEvent();

                _goals.Add(g);
            }
        }

        Console.WriteLine("Loaded!");
    }

    private void RecordGoalEvent()
    {
        Console.WriteLine("Choose a goal:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        int index = int.Parse(Console.ReadLine()) - 1;

        int earned = _goals[index].RecordEvent();
        _score += earned;

        Console.WriteLine($"You earned {earned} points!");

        
        Console.WriteLine(GetMotivationalMessage());
    }

   
    private string GetMotivationalMessage()
    {
        string[] messages =
        {
            "🔥 Great job! Keep pushing forward!",
            "⭐ You're building momentum!",
            "💪 Discipline beats motivation.",
            "🚀 Small steps lead to big victories.",
            "🏆 Success is inevitable if you stay consistent."
        };

        Random r = new Random();
        return messages[r.Next(messages.Length)];
    }
}


