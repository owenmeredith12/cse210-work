using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        
        Job job1 = new Job();
        Job job2 = new Job();
        Resume resume = new Resume();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2001;
        job1._endYear = 2005;

        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2005;
        job2._endYear = 2010;

        resume._name = "Bob";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();

        
    }
}