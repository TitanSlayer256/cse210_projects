using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        // Verify Constructors
        Fraction fractionOne = new Fraction();          // 1/1
        Fraction fractionTwo = new Fraction(5);         // 5/1
        Fraction fractionThree = new Fraction(3, 4);      // 3/4
        Fraction fractionFour = new Fraction(1, 3);      // 1/3

        // Display results
        Console.WriteLine(fractionOne.GetFractionString());
        Console.WriteLine(fractionOne.GetDecimalValue());

        Console.WriteLine(fractionTwo.GetFractionString());
        Console.WriteLine(fractionTwo.GetDecimalValue());

        Console.WriteLine(fractionThree.GetFractionString());
        Console.WriteLine(fractionThree.GetDecimalValue());

        Console.WriteLine(fractionFour.GetFractionString());
        Console.WriteLine(fractionFour.GetDecimalValue());

        //Random thingymabobber
        Fraction randomFraction = new Fraction();
        Random randomGenerator = new Random();

        for (int i = 1; i <27; i++)
        {
            // Generate random numbers
            int randomTop = randomGenerator.Next(1, 11); // 1 to 10
            int randomBottom = randomGenerator.Next(1, 11); // 1 to 10

            randomFraction.SetTop(randomTop);
            randomFraction.SetBottom(randomBottom);

            string output = randomFraction.GetFractionString();
            double decimalValue = randomFraction.GetDecimalValue();

            Console.WriteLine($"Fraction {i}, is {output}, and has a decimal value of {decimalValue}");
        }
    }
}
