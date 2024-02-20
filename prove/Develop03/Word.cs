using System;

class Word
{
    public int Length { get; }
    public string Text { get; set; }
    public bool Hidden { get; set; }

    // Constructor
    public Word(int length, string text)
    {
        Length = length;
        Text = text;
        Hidden = false;
    }

    public void HideWord()
    {
        Hidden = true;
    }
}

