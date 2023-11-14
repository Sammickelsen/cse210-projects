public class EternalGoal : Goal
{
    private bool _onceComplete;

    public EternalGoal(string description, string type = "EternalGoal") : base(type, description)
    { 
    }

    public override void IsComplete()
    {
        if (_onceComplete == true)
        {
            Console.WriteLine("{X}");
        }
        else
        {
            Console.WriteLine("{ }");
        }
    }
}