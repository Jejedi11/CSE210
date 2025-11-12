using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Word word = new Word();
        word.Hide();
        Console.WriteLine(word.GetWord());
    }
}