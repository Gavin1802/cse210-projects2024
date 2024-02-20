using System;
using System.Collections.Generic;

class Scripture
{
    private List<Word> Words { get; }
    public Reference Reference { get; }

    // Constructor which creates an array for words in the scripture
    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = new List<Word>();
        string[] wordArray = text.Split(' ');

        foreach (string wordText in wordArray)
        {
            Word word = new Word(wordText.Length, wordText);
            Words.Add(word);
        }
    }

    // Change 3 words to underscores with each 'Enter'
    public void RemoveWords()
    {
        Random random = new Random();
        int wordsHiddenCount = 0;

        while (wordsHiddenCount < 3)
        {
            int randomIndex = random.Next(0, Words.Count);
            Word word = Words[randomIndex];

            if (!word.Hidden)
            {
                string underscoreText = new string('_', word.Length);
                word.Text = underscoreText;
                word.HideWord();
                wordsHiddenCount++;
            }
        }
    }

    // Checks if all words are hidden
    public bool AllWordsHidden
    {
        get
        {
            foreach (Word word in Words)
            {
                if (!word.Hidden)
                {
                    return false;
                }
            }
            return true;
        }
    }

    //Put together and return the updated scripture
    public string GetVisibleText()
    {
        List<string> visibleTexts = new List<string>();
        foreach (Word word in Words)
        {
            if (word.Hidden)
            {
                visibleTexts.Add(new string('_', word.Length));
            }
            else
            {
                visibleTexts.Add(word.Text);
            }
        }
        return string.Join(" ", visibleTexts);
    }
}


