using System;

class Program
{
    static void Main(string[] args)
    {
        SaveAndLoad saveAndLoadHandler = new SaveAndLoad();
        saveAndLoadHandler.Save("teej.txt", "wowzerjkjjk");
        string output = saveAndLoadHandler.Load("teej.txt");
        Console.WriteLine(output);
    }
}