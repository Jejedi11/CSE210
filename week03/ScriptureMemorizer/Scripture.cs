using System.ComponentModel.DataAnnotations;

public class Scripture
{
    private List<Word> words = new List<Word>();
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        List<string> stringWords = text.Split(" ").ToList();
        foreach (string word in stringWords)
        {
            Word newWord = new Word(word);
            words.Add(newWord);
        }
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int changed = 0;

        while (changed < 3)
        {
            int num = random.Next(1, words.Count());
            if (words[num].IsHidden() == false)
            {
                words[num].Hide();
                changed++;
            }
                
        }
        
    }

    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText();
        foreach (Word word in words)
        {
            display += word.GetDisplayText() + " ";
        }
        return display;
    }
}