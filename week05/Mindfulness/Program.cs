using System;

class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Welcome to the mindfulness program. Today we are going to do some activites to bolster your mindfulness");
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activitiy");
            Console.WriteLine("\t4. Quit");
            Console.WriteLine("Please select a choice");
            string choice = Console.ReadLine();
            Activity activity = null;
            if (choice == "4")
            {
                break;
            }

            else if (choice == "3")
            {
                activity = new Listing();
                activity.runActivity();


            }

            else if (choice == "2")
            {
                activity = new Reflection();
                activity.runActivity();


            }

            else if (choice == "1")
            {
                activity = new Breathing();
                activity.runActivity();

            }

        }
    }
}
