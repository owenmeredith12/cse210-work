using System;

class Program
{
    static void Main(string[] args)
    {
        string reference = "Proverbs 3:5-6";
        string scripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths";

        Scripture scripture1 = new Scripture(scripture);

        scripture1.setReference(reference);

        scripture1.seperateWords();
    }
}