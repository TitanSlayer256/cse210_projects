using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        Console.WriteLine("Keep typing numbers to be added to the list, type zero when you want to stop");
        int input = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int avg;
        int high;
        int amount = 0;
        int highestInt;
        while (input != 0)
        {
            numbers.Add(input);
            input = Convert.ToInt32(Console.ReadLine());
        }

        string result = string.Join(", ", numbers);
        Console.WriteLine(result);

        Console.Write("Here was the sum of your numbers: ");
        foreach (int number in numbers)
        {
            sum += number;
            amount++;
        }
        avg = sum/amount;
        Console.WriteLine(sum);

        Console.Write("Here was the average of your numbers: ");
        Console.WriteLine(avg);
        
        highestInt = numbers.Max();
        Console.Write("Here was your maximum value: ");
        Console.WriteLine(highestInt);
    }   
}