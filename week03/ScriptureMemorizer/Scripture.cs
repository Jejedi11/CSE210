using System.ComponentModel.DataAnnotations;

public class Scripture
{
    private List<Word> words = new List<Word>();
    private Reference _reference;
    private bool _isCompletelyHidden = false;

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

    public string IsCompletelyHidden()
    {
        if (_isCompletelyHidden == true)
        {
            return "quit";
        }
        else
        {
            return "";
        }
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        for (int i = 0 ; i < 3 ; i++)
        {
            int num = random.Next(0, words.Count());
            if (words[num].IsHidden() == false)
            {
                words[num].Hide();
            }

            int changed = 0;
            foreach (Word word in words)
            {
                if (word.IsHidden() == true)
                {
                    changed++;
                }
            }
                if (changed == words.Count())
                {
                    _isCompletelyHidden = true;
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