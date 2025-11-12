using System.Security.Cryptography.X509Certificates;

public class Word()
{
    private string _word;

    private bool _visible = true;

    public void Hide()
    {
        _visible = false;
        string sub = "";
        foreach (int i in _word)
        {
            sub = sub + "_";
        }
        _word = sub;
    }

    public string GetWord()
    {
        return _word;
    }
}