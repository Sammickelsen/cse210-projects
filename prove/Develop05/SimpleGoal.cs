public class SimpleGoal : Goal
{
    private bool _complete;

    public SimpleGoal(string name, string description) : base(name, description)
    {
    }

    public override void IsComplete()
    {
        if (_complete == true)
        {
            Console.WriteLine("{X}");
        }
        else
        {
            Console.WriteLine("{ }");
        }
    }
}