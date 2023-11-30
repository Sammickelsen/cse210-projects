public class Week
{
    public List<Day> week = new List<Day>();
    public string weekName;

    public Week(string name = "Week 1")
    {
        weekName = name;

        Day sunday = new Day("Sunday");
        Day monday = new Day("Monday");
        Day tuesday = new Day("Tuesday");
        Day wednesday = new Day("Wednesday");
        Day thursday = new Day("Thursday");
        Day friday = new Day("Friday");
        Day saturday = new Day("Saturday");

        week.Add(sunday);
        week.Add(monday);
        week.Add(tuesday);
        week.Add(wednesday);
        week.Add(thursday);
        week.Add(friday);
        week.Add(saturday);
    }

    public void DisplayWeek()
    {
        foreach (Day d in week)
        {
            d.DisplayDay();
        }
    }

    public void PlanWeek(List<Meal> breakfasts, List<Meal> lunches, List<Meal> dinners)
    {
        bool planLoop = true;
        do
        {
            Console.Clear();
            Console.WriteLine("Choose a day to edit. \nWhen you are done, type 0.\n");
            int i = 1;
            foreach (Day d in week)
            {
                Console.WriteLine($"{i}. {d.dayName}");
                i++;
            }

            Console.Write("\n> ");
            int choice = Int32.Parse(Console.ReadLine());
            if (choice == 0)
            {
                planLoop = false;
            }
            else if (choice <= 7)
            {
                week[choice - 1].PlanDay(breakfasts, lunches, dinners);
            }
        } while (planLoop == true);
    }
}