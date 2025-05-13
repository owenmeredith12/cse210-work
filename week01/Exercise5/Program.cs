using System;
using System.Globalization;

class Program
{

    static void displayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string promptUserName()
    {
        Console.WriteLine("Please enter your user name");
        string name = Console.ReadLine();
        return name;
    }

    static int promptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number");
        int num = Convert.ToInt32(Console.ReadLine());
        return num;
    }

    static int squareNumber(int num)
    {
        num = num * num;
        return num;
    }

    static void displayResult(int num, string name)
    {
        Console.WriteLine(name + ", the square of yoru number is " + num);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        displayWelcome();
        string name = promptUserName();
        int num = promptUserNumber();
        int square = squareNumber(num);
        displayResult(square, name);

    }
}