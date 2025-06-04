public class Listing : Activity
{
    private string[] _prompts = { "Who do you appreciate", "What are your strengths", "List everyone in your life that loves you" };
    public Listing() : base("Listing Activity", "This activity will help you list as many things as you can in a certain area")
    {

    }

    public override void runActivity()
    {
        start();
        var rnd = new Random();
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($">>> {_prompts[rnd.Next(_prompts.Length)]}");
        Console.WriteLine("\nStart listing in:");
        countdown(5);

        int duration = GetLength();
        DateTime end = DateTime.Now.AddSeconds(duration);
        int count = 0;

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items.");
        stop();
    }
}