using System;

class Program
{
    static void Main(string[] args)
    {
        //Creates the reference as well as the text for the scripture
        Reference ref1 = new Reference("D&C", 25, 12);
        string text = "For my soul delighteth in the song of the heart; yea, the song of the righteous is a prayer unto me, and it shall be answered with a blessing upon their heads.";
        //Creates the scripture by inputting the reference and the text
        Scripture scripture = new Scripture(ref1, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to hide words or type quit to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit" || scripture.IsCompletelyHidden()) //end if the input is quit or scripture is completely hidden
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}