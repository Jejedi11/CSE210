using System.Security.Cryptography.X509Certificates;

public class Word
{
    private string _text;

    private bool _isHidden = false;

    public Word(string word)
    {
        _text = word;
    }

    public void Hide()
    {
        string newWord = "";
        foreach (char c in _text)
        {
            newWord += "_";
        }
        _text = newWord;
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }

    
}