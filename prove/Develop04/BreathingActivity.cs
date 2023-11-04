public class BreathingActivity : Activity
{
    public BreathingActivity(string ActivityName, string Description) : base(ActivityName, Description)
    {

    }

    public void InAndOutLoop()
    {
        int totalTime = _duration;
        int breaths = 3;
        int breathTime = totalTime / (2 * breaths);

        Console.WriteLine("Starting Beathing Activity in 3 seconds...");
        LoadingAnimation();

        for (int i = 1; i <= breaths; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Breath {i}: Breathe in for {breathTime} seconds.");
            for (int j = breathTime; j > 0; j--)
            {
                Console.Write("\r" + new string(' ', Console.WindowWidth - 1));
                Console.Write("\r" + $"Breath In...{j}");
                Thread.Sleep(1000);
                
                
            }
            Console.WriteLine();
            Console.WriteLine($"Breath {i}: Breathe out for {breathTime} seconds.");
            for (int j = breathTime; j > 0; j--)
            {
                Console.Write("\r" + new string(' ', Console.WindowWidth - 1));
                Console.Write("\r" + $"Breath Out...{j}");
                Thread.Sleep(1000);
                
                
            }
        }
    }

}