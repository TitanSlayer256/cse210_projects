using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(101); // Generates a number between 0 and 99

        Console.WriteLine("Guess a Number between 1 and 100.");

        Console.Write("What is your guess?");
        int guess = Convert.ToInt32(Console.ReadLine());;

        if (guess == magicNumber)
        {
            Console.WriteLine("Wow you got it on the first try!");
        }
        while (guess != magicNumber)
        {  
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            } else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            Console.Write("What is your guess?");
            guess = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Bingo! You got it!");


    }
}