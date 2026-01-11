using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage?(0-100 no decimals)");
        int grade = int.Parse(Console.ReadLine());
        string letter;

        //Determines their letter grade.
        if (grade >= 90)
        {
            letter = "A";
        } else if (grade >= 80)
        {
            letter = "B";
        } else if (grade >= 70)
        {
            letter = "C";
        } else if (grade >= 60)
        {
            letter = "D";
        } else
        {
            letter = "F";
        }

        //Writes the message for what grade they received.
        Console.WriteLine($"You received an {letter}.");

        //Determines whether they passes or not.
        if (grade >= 70){
            Console.Write("Congratulations, you passed!");
        } else {
            Console.Write("Unfortunately, you failed.  Better luck next time!");
        }
    }
}