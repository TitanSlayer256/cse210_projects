public class ListingActivity : Activity //Inherits from the Activity class
{
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life.") {}

    public void Run()
    {
        DisplayStartingMessage();
        Random random = new Random();
        
        Console.WriteLine("\nList as many items as you can to the following prompt:");
        Console.WriteLine($" --- {_prompts[random.Next(_prompts.Count)]} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items!");
        DisplayEndingMessage();
    }
}