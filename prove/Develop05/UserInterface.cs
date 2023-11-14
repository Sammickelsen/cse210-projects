public class UserInterface
{
    public List<Goal> GoalList = new List<Goal>();
    private int _totalPoints;
    
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

    public void DisplayPoints()
    {

    }

    public void NewGoal()
    {
        Console.WriteLine("What type of goal would you like to make?");
        Console.WriteLine("1. Eternal Goal \n2. Simple Goal \n3. Checklist Goal");
        Console.Write("> ");
        string response = Console.ReadLine();

        if (response == "1")
        {
            Console.Write("Please type out your intended Eternal Goal: ");
            string goalDesc = Console.ReadLine();

            EternalGoal newEternalGoal = new EternalGoal(goalDesc);
            GoalList.Add(newEternalGoal);
        }
        else if (response == "2")
        {
            Console.Write("Please type out your intended Simple Goal: ");
            string goalDesc = Console.ReadLine();

            SimpleGoal newSimpleGoal = new SimpleGoal(goalDesc);
            GoalList.Add(newSimpleGoal);
        }
        else if (response == "3")
        {
            Console.Write("Please type out your intended Checklist Goal: ");
            string goalDesc = Console.ReadLine();

            Console.Write("Please type how many times you want to complete your Checklist Goal: ");
            int maxComplete = Int32.Parse(Console.ReadLine());

            ChecklistGoal newChecklistGoal = new ChecklistGoal(goalDesc, maxComplete);
            GoalList.Add(newChecklistGoal);
        }
        else
        {
            Console.WriteLine("Not a valid response.");
        }
    }
}