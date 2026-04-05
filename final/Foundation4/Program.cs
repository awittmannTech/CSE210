class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 3.0f),
            new Cycling("03 Nov 2022", 45, 15.0f),
            new Swimming("03 Nov 2022", 30, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
