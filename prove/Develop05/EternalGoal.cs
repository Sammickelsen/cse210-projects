public class EternalGoal : Goal
{
    private bool _onceComplete;

    public EternalGoal(string name, string description) : base(name, description)
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