using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your grade?");
        int grade = Convert.ToInt32(Console.ReadLine());

        if (grade >= 90)
        {
            Console.WriteLine("You got an A");
        }

        if (grade >= 80 && grade < 90)
        {
            Console.WriteLine("You got an B");
        }

        if (grade >= 70 && grade < 80)
        {
            Console.WriteLine("You got an C");
        }

        if (grade >= 60 && grade < 70)
        {
            Console.WriteLine("You got an D");
        }

        if (grade < 60)
        {
            Console.WriteLine("You got an F");
        }

    }
}