using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter multiple numbers, when you are finished enter 0");

        int x = 1;
        List<int> nums = new List<int>();

        while (x > 0)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            nums.Add(number);
            if (number == 0)
            {
                break;

            }

        }

        for (int i = 0; i < nums.Count; i++)
        {
            Console.WriteLine(nums[i]);
        }

        int sum = 0;
        int largest = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            sum += nums[i];
            if (nums[i] > largest)
            {
                largest = nums[i];
            }

        }

        float average = ((float)sum) / nums.Count;
        Console.WriteLine(sum);
        Console.WriteLine(average);
        Console.WriteLine(largest);

    }
}