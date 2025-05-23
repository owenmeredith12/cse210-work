using System.Runtime.InteropServices;

public class Scripture
{
    private string _scripture;
    private string _reference;

    public Scripture(string scripture)
    {
        _scripture = scripture;

    }

    public void setScripture(string scripture)
    {
        _scripture = scripture;
    }

    public string getScripture()
    {
        return _scripture;
    }

    public void setReference(string reference)
    {
        Reference reference1 = new Reference(reference);
        _reference = reference;
    }

    public void seperateWords()
    {
        List<Word> scripture = new List<Word>();

        string[] words = _scripture.Split(' ');
        foreach (string word in words)
        {
            Word word1 = new Word(word);
            word1.setWord(word);
            scripture.Add(word1);


        }

        Console.WriteLine(_reference);
        Console.WriteLine(string.Join(" ", words));

        while (true)
        {



            Console.WriteLine("\nPress Enter to hide words or type quit to quit the program");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            else
            {
                Random random = new Random();
                Random random1 = new Random();
                Random random2 = new Random();

                int index = random.Next(scripture.Count);
                int index1 = random1.Next(scripture.Count);
                int index2 = random2.Next(scripture.Count);

                scripture[index].setHidden();
                scripture[index1].setHidden();
                scripture[index2].setHidden();

                Console.Clear();
                Console.WriteLine(_reference);
                int count = 0;
                for (int i = 0; i < scripture.Count; i++)
                {
                    if (scripture[i].checkHidden() == true)
                    {
                        count++;

                    }
                    Console.Write($"{scripture[i]} ");

                }

                if (count == scripture.Count)
                {
                    break;
                }


                continue;
            }
        }
    }

}