public class SimpleGoal : Goal
{
    private bool _complete;

    public SimpleGoal(string description, string type = "SimpleGoal") : base(type, description)
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