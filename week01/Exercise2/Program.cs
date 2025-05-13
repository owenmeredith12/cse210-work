using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your grade?");
        int grade = Convert.ToInt32(Console.ReadLine());
        char letter = ' ';

        if (grade >= 90)
        {
            letter = 'A';
        }

        if (grade >= 80 && grade < 90)
        {
            letter = 'B';
        }

        if (grade >= 70 && grade < 80)
        {
            letter = 'C';
        }

        if (grade >= 60 && grade < 70)
        {
            letter = 'D';
        }

        if (grade < 60)
        {
            letter = 'F';
        }

        Console.WriteLine("Your Class Grade: " + letter);

        if (grade >= 70)
        {
            Console.WriteLine("You passed the class");
        }

        if (grade < 70)
        {
            Console.WriteLine("You failed the class");
        }

    }
}