public class ReflectionActivity : Activity //Inherits from the Activity class
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };
    
    private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times of strength.") {}

    public void Run()
    {
        DisplayStartingMessage();
        Random random = new Random();
        
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($" --- {_prompts[random.Next(_prompts.Count)]} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write($"> {_questions[random.Next(_questions.Count)]} ");
            ShowSpinner(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}