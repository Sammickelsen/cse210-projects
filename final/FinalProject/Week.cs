public class Week
{
    public List<Day> week = new List<Day>();

    public Week()
    {
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
}