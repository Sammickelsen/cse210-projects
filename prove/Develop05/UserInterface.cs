public class UserInterface
{
    public List<Goal> GoalList = new List<Goal>();
    public int totalPoints;
    
    public UserInterface()
    {

    }

    public void DisplayGoals()
    {
        foreach (Goal g in GoalList)
        {
            g.DisplayGoal();
        }
    }

    public void UpdateGoal()
    {
        Console.WriteLine("What goal would you like to mark done? (Type number)");
        int i = 0;
        foreach (Goal g in GoalList)
        {
            Console.WriteLine($"{i + 1}. {g.GetName()}");
            i ++;
        }
        Console.Write("\n> ");
        int userChoice = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Updating...\n\n");
        totalPoints += GoalList[userChoice - 1].UpdatePoints();
        GoalList[userChoice - 1].MarkDone();
        
    }

    public void NewGoal()
    {
        Console.WriteLine("What type of goal would you like to make?");
        Console.WriteLine("1. Eternal Goal \n2. Simple Goal \n3. Checklist Goal");
        Console.Write("> ");
        string response = Console.ReadLine();

        if (response == "1")
        {
            Console.Write("Please type out the name of your intended goal: ");
            string goalName = Console.ReadLine();

            Console.Write("Please write a description of your goal: ");
            string goalDesc = Console.ReadLine();

            EternalGoal newEternalGoal = new EternalGoal(goalDesc, goalName);
            GoalList.Add(newEternalGoal);
        }
        else if (response == "2")
        {
            Console.Write("Please type out the name of your intended goal: ");
            string goalName = Console.ReadLine();

            Console.Write("Please write a description of your goal: ");
            string goalDesc = Console.ReadLine();

            SimpleGoal newSimpleGoal = new SimpleGoal(goalDesc, goalName);
            GoalList.Add(newSimpleGoal);
        }
        else if (response == "3")
        {
            Console.Write("Please type out the name of your intended goal: ");
            string goalName = Console.ReadLine();

            Console.Write("Please write a description of your goal: ");
            string goalDesc = Console.ReadLine();

            Console.Write("Please type how many times you want to complete your goal: ");
            int maxComplete = Int32.Parse(Console.ReadLine());

            ChecklistGoal newChecklistGoal = new ChecklistGoal(goalDesc, goalName, maxComplete);
            GoalList.Add(newChecklistGoal);
        }
        else
        {
            Console.WriteLine("Not a valid response.");
        }
    }


}