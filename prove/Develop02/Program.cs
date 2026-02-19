using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Establishes the journal
        Journal myJournal = new Journal();
        bool running = true;

        Console.WriteLine("Welcome to my Journal Program!");

        while (running)
        {
            //All the text that the user sees at the beginning of the program loop.
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");

            //Takes the user's choice
            string choice = Console.ReadLine();

            //Logic to decide what to do based on the user's choice
            if (choice == "1")
            {
                //Creates a new entry and sets the prompt text.
                Entry newEntry = new Entry();
                newEntry._promptText = newEntry.GetRandomPrompt();
                
                //Writes the prompt text to the console and sets the date and accepts the entry text.
                Console.WriteLine($"\nPrompt: {newEntry._promptText}");
                Console.Write("> ");
                newEntry._entryText = Console.ReadLine();
                newEntry._date = DateTime.Now.ToShortDateString();
                
                //Adds the new entry to the journal
                myJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                myJournal.LoadFromFile();
            }
            else if (choice == "4")
            {
                myJournal.SaveToFile();
            }
            else if (choice == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }

        Console.WriteLine("Goodbye! Thank you for using the Journal Program.");
    }
}

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    //This method returns a random prompt to get the brain juices going.
    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Count); // Picks a random number from 0 to 4
        return prompts[index];
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}\n");
    }

}

public class Journal
{
    List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        //Asks the user for the filename to save the journal
        Console.WriteLine("Enter filename to save journal:");
        string filename = Console.ReadLine();

        //This part I had a little help with because I wasn't super familiar with file handling in C#
        //I understand it better now though.
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
    public void LoadFromFile()
    {
        Console.WriteLine("Enter filename to load journal:");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            //the file exist so continue loading
            _entries.Clear();

            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                //Split the line into parts anywhere there is a vertical line |
                string[] parts = line.Split('|');

                //Creates a new entry and fills in the data from the file
                Entry newEntry = new Entry();
                newEntry._date = parts[0];
                newEntry._promptText = parts[1];
                newEntry._entryText = parts[2];

                //Add the entry back to our list.
                _entries.Add(newEntry);
            }
        } else
        {
            Console.WriteLine("File not found.");
        }
    }
}