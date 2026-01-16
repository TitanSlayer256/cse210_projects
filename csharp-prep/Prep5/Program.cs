using System;
using System.Security.Cryptography;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!:)");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number?");
        int favoriteNumber = Convert.ToInt32(Console.ReadLine());
        return favoriteNumber;
        
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("What is your birth year?");
        birthYear = Convert.ToInt32(Console.ReadLine());
    }
    static int SquareNumber(ref int x)
    {
        x = x*x;
        return x;
    }
    static void DisplayResult(ref string name, ref int SquareNumber, ref int birthYear)
    {
        int age = 2026 - birthYear;
        Console.WriteLine($"{name}, the square of your number is, {SquareNumber}");
        Console.WriteLine($"{name}, you will turn {age} this year." );
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        PromptUserBirthYear(out int birthYear);
        int squareNumber = SquareNumber(ref favoriteNumber);
        DisplayResult(ref name, ref squareNumber, ref birthYear);
    }
}