using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("Give me a random number that is less than 10");
        int number = Convert.ToInt32(Console.ReadLine());

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