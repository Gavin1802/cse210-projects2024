using System;

class Reference
{
    private string Book { get; }
    private int Chapter { get; }
    private string Verse { get; }

    // Constructor
    public Reference(string book, int chapter, string verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
    }

    // Assemble the Reference
    public void DisplayReference()
    {
        Console.WriteLine($"{Book} {Chapter}: {Verse}");
    }
}

