public class Reflection : Activity
{
    private string[] _prompts =
{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public Reflection() : base("Reflection Activity", "This activity will help you relax by walking you through a reflection to highlight your strength")
    {

    }



    public override void runActivity()
    {
        start();
        var rnd = new Random();
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($">>> {_prompts[rnd.Next(_prompts.Length)]}");
        showAnim(5);

        int elapsed = 0;
        int duration = GetLength();
        while (elapsed < duration)
        {
            Console.WriteLine($"\n{_questions[rnd.Next(_questions.Length)]}");
            showAnim(5);
            elapsed += 5;
        }
        stop();
    }
}