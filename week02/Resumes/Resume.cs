using System;

public class Resume{
    public string _name = " ";

    public List<Job> _jobs = new List<Job>(); 

    public void Display(){
        Console.WriteLine(_name);
        Console.WriteLine($"Job1 {_jobs[0]._jobTitle} {_jobs[0]._company} ({_jobs[0]._startYear} - {_jobs[0]._endYear}) ");
        Console.WriteLine($"Job1 {_jobs[1]._jobTitle} {_jobs[1]._company} ({_jobs[1]._startYear} - {_jobs[1]._endYear}) ");
    }
}