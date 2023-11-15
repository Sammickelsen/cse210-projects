using System.Runtime.CompilerServices;
using System.IO;

public class ReadWrite
{

    public ReadWrite()
    {}

    public int ReadPoints(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        return Int32.Parse(lines[0]);
    }

    public List<Goal> ReadGoals(string fileName)
    {
        List<Goal> readGoals = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines.Skip(1))
        {

            string[] halves = line.Split(":");

            string goalType = halves[0];
            string propString = halves[1];
            string[] properties = propString.Split("|");
            string goalName = properties[0];
            string goalDesc = properties[1];
            int points = Int32.Parse(properties[2]);

            if (goalType == "SimpleGoal")
            {
                bool isComplete = bool.Parse(properties[3]);
                SimpleGoal newGoal = new SimpleGoal(goalDesc, goalName, goalType, points, isComplete);
                readGoals.Add(newGoal);
            }
            else if (goalType == "ChecklistGoal")
            {
                int finishedPoints = Int32.Parse(properties[3]);
                int maxComplete = Int32.Parse(properties[4]);
                int timesComplete = Int32.Parse(properties[5]);

                ChecklistGoal newGoal = new ChecklistGoal(goalDesc, goalName, maxComplete, timesComplete, goalType, points, finishedPoints);
                readGoals.Add(newGoal);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal newGoal = new EternalGoal(goalDesc, goalName, goalType, points);
                readGoals.Add(newGoal);
            }
            else
            {
                Console.WriteLine("Error, not reading correctly.");
            }
        }

        return readGoals;
    }

    public void WriteFiles(List<Goal> goals, int totalPoints, string fileName)
    {
        List<string> goalStrings = new List<string>();

        foreach (Goal g in goals)
        {
            string goalString = g.GoaltoString();
            goalStrings.Add(goalString);

            
        }

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine($"{totalPoints}");
                
            foreach (string goalString in goalStrings)
            { 
                outputFile.WriteLine(goalString);
            }        
        }
    }

    public void GetStringRepresentation()
    {

    }

    public void CreateGoal()
    {
        
    }
}