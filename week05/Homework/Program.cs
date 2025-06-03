using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment = new Assignment("steve", "addition");
        //assignment.getSummary();
        MathAssignment mathAssignment = new MathAssignment("steve", "addition", "7.3", "6-10");
        mathAssignment.getSummary();
        mathAssignment.getHomeworkList();
    }
}