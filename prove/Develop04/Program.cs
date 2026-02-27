using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = ""; //initialize the variable for the user's choice
        while (choice != "4") //Logic to loop menu until the user selects 4 to quit
        {
            //Continuously creates the menu each time the user completes an activity until they select 4 to quit
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            //logic to run the activity based on the user's choice
            if (choice == "1") {
                BreathingActivity ba = new BreathingActivity();
                ba.Run();
            }
            else if (choice == "2") {
                ReflectionActivity ra = new ReflectionActivity();
                ra.Run();
            }
            else if (choice == "3") {
                ListingActivity la = new ListingActivity();
                la.Run();
            }
        }
    }
}