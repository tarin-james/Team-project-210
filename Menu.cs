/*Journal Program;
This program takes responses from user and 
saves them in a chronological file;
Ryan Holt CopyWright Oct2,2023*/

public class Menu
{
    public string _userChoice;
    public List<string> _menuList = new List<string>() {"1. Write", "2. Display", "3. Load",
    "4. Save", "5. Quit"};

    public void DisplayMenu()
    {
        foreach (string option in _menuList)
        {
            Console.WriteLine(option);

        }
        _userChoice = Console.ReadLine();
        

        switch (_userChoice)
        {
            case "1":
            /*call new entry, not sure where to put the new instance of entry*/
            Console.WriteLine(1);
            break;

            case "2":
            
            Console.WriteLine(2);
            break;

            case "3":
            Console.WriteLine(3);
            break;

            case "4":
            Console.WriteLine(4);
            break;

            case "5":
            Console.WriteLine(5);
            break;

            default:
            Console.WriteLine("Please enter a whole number between 1 and 5.");
            DisplayMenu();
            break;

            
        }
    }

    /*
    public void DisplayFile()
    {

    }

    public string CreateEntry()
    {
        return Entry;
    }

    public 
    */

}
