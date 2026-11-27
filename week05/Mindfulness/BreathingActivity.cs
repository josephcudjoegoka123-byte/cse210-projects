public class BreathingActivity : Activity
{
    public BreathingActivity() : base ("Breathing",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."){}
    public void Run()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        for (int i = 0; i < 4; i++)
        {
            Console.Write("Breathe in ...");
            ShowCountDown(4);

            Console.Write("Now Breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
            
        }
        DisplayEndingMessage();
    }

}