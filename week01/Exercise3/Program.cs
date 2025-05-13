using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random rand = new Random();
        int number = rand.Next(0, 10);

        Console.WriteLine("Give me a guess");
        int guess = Convert.ToInt32(Console.ReadLine());
        if (guess == number)
        {
            Console.WriteLine("You got it!");
        }


        else
        {

            if (guess < number)
            {
                Console.WriteLine("Higher");
            }

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            while (guess != number)
            {
                Console.WriteLine("Give me another guess");
                int guessAgain = Convert.ToInt32(Console.ReadLine());

                if (guessAgain < number)
                {
                    Console.WriteLine("Higher");
                }

                if (guessAgain > number)
                {
                    Console.WriteLine("Lower");
                }

                if (guessAgain == number)
                {
                    Console.WriteLine("You got it!");
                    break;
                }
            }
        }
    }
}