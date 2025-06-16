class Program
{
    private static List<Goal> goals = new List<Goal>();

    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Set goal");
            Console.WriteLine("2. Show goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": SetGoal(); break;
                case "2": ShowGoals(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": running = false; break;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    static void SetGoal()
    {
        Console.WriteLine("Choose goal type:\n1. Simple\n2. Eternal\n3. Checklist");
        string type = Console.ReadLine();
        Goal goal = null;

        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                goal = new SimpleGoal();
                break;
            case "2":
                goal = new EternalGoal();
                break;
            case "3":
                var checklist = new ChecklistGoal();
                Console.Write("Enter target count: ");
                checklist.SetTargetCount(int.Parse(Console.ReadLine()));
                Console.Write("Enter bonus points: ");
                checklist.SetBonusPoints(int.Parse(Console.ReadLine()));
                goal = checklist;
                break;
            default:
                Console.WriteLine("Invalid type.");
                return;
        }

        goal.SetName(name);
        goal.SetDescription(desc);
        goal.SetPoints(points);
        goals.Add(goal);
    }

    static void ShowGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals yet.");
            return;
        }

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
    }

    static void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }

        Console.WriteLine("Goals saved.");
    }

    static void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        goals.Clear();
        foreach (var line in File.ReadAllLines(filename))
        {
            string[] parts = line.Split('|');
            Goal goal = null;

            switch (parts[0])
            {
                case "SimpleGoal": goal = new SimpleGoal(); break;
                case "EternalGoal": goal = new EternalGoal(); break;
                case "ChecklistGoal": goal = new ChecklistGoal(); break;
            }

            goal?.Deserialize(line);
            if (goal != null) goals.Add(goal);
        }

        Console.WriteLine("Goals loaded.");
    }

    static void RecordEvent()
    {
        ShowGoals();
        Console.Write("Select goal number to record: ");
        if (int.TryParse(Console.ReadLine(), out int index) &&
            index >= 1 && index <= goals.Count)
        {
            int earned = goals[index - 1].RecordEvent();
            Console.WriteLine($"Event recorded. You earned {earned} points.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
}