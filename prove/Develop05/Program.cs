using System;

class Program
{
    static void Main(string[] args)
    {
        UserInterface myUserInterface = new UserInterface();

        EternalGoal newEternalGoal = new EternalGoal("Go to the temple.");
        SimpleGoal newSimpleGoal = new SimpleGoal("Finish programming assignment.");
        ChecklistGoal newChecklist = new ChecklistGoal("Study every day this week.", 7);

        myUserInterface.NewGoal();
        myUserInterface.NewGoal();
        myUserInterface.NewGoal();

        myUserInterface.DisplayGoals();
    }
}