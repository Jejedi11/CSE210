using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void MakeEntry(string prompt)
    {
        Entry entry = new Entry();
        entry._date = DateTime.Now.ToString("d");
        entry._prompt = prompt;
        Console.WriteLine(entry._prompt);
        Console.Write("> ");
        entry._response = Console.ReadLine();
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry item in _entries)
        {
            item.Display();
        }

    }

    public void LoadFile(string filename, Journal journal)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];

            journal._entries.Add(entry);
        }
    }

    public void SaveFile(string filename)
    {
        using(StreamWriter output = new StreamWriter(filename))
        {
            foreach (Entry item in _entries)
            {
                output.WriteLine($"{item._date},{item._prompt},{item._response}");
            }
        }
    }
}

