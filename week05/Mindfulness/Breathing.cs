public class Breathing : Activity
{
    public Breathing() : base("Breathing Activity", "This activity will help you by walking you through intentional breathing")
    {

    }

    public override void runActivity()
    {
        start();
        int length = GetLength();
        int elapsed = 0;
        while (elapsed < length)
        {
            Console.WriteLine("\nBreathe in ...");

            countdown(4);

            Console.WriteLine("\nBreathe out ...");

            countdown(4);

            elapsed += 8;
        }
        stop();
    }
}