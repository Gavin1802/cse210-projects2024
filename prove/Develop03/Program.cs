using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Parameters of the Book, Chapter, and Verse(s)
        Reference reference = new Reference("3 Nephi", 11, "10-11");
        var scriptureText = "Behold, I am Jesus Christ, whom the prophets testified shall come into the world. And behold, I am the light and the life of the world; and I have drunk out of that bitter cup which the Father hath given me, and have glorified the Father in taking upon me the sins of the world, in the which I have suffered the will of the Father in all things from the beginning.";
        Scripture scripture = new Scripture(reference, scriptureText);

        //Clear console screen and display the scripture
        ClearAndDisplayScripture(scripture);

        // Prompt the user to press enter to hide 3 words or quit
        while (!scripture.AllWordsHidden)
        {
            Console.WriteLine("Press Enter to hide 3 random words or type 'quit' to exit:");
            string userInput = Console.ReadLine();

            // Check if the user wants to quit
            if (userInput == "quit")
            {
                return;
            }
            scripture.RemoveWords();
            ClearAndDisplayScripture(scripture);
        }
    }

    // Clears the console and displays the updated scripture
    static void ClearAndDisplayScripture(Scripture scripture)
    {
        Console.Clear();
        Console.Write($"Reference: ");
        scripture.Reference.DisplayReference();
        Console.WriteLine("Scripture:");
        Console.WriteLine(scripture.GetVisibleText());
    }
}

