using System.IO;

class SaveAndLoad
{
    public string Load(string fileName) {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        string output = "";
        foreach (string line in lines)
        {
            output += line;
        }
        return output;
    }

    public void Save(string fileName, string journalEntry) {

        using StreamWriter outputFile = new StreamWriter(fileName);

        outputFile.WriteLine(journalEntry);

    }
    
     
    
}