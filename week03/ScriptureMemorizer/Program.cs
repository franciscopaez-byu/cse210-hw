using System;
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, text);

        string input = "";

        while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            
            Console.WriteLine("Read the text aloud and press Enter to hide words.");
            Console.WriteLine("Do this until all words are hidden and you can recite the phrase from memory!");
            Console.WriteLine("\nType 'quit' to exit or press Enter to continue:");
            
            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nCongratulations! All words are hidden.");
        Console.WriteLine("I hope you have memorized the scripture!");
    }
}