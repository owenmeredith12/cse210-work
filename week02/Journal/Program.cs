//the extra part of my program keeps track of the words in and entry by splitting
//the entry string up by spaces or new line characters and then counting the length
//of that string. this is then displayed at the bottom of the entry


using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Journal Project.");
        Journal journal = new Journal();

        journal.displayOptions();
    }
}