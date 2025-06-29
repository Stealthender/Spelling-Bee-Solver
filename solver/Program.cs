public class MainClass
{
    private static int nletters = 7; //Spelling bee has 7 letters

    public static void Main()
    {
        char[] letters = getInput();
        string[] wordlist = LibraryClass.library(letters);
        foreach (string word in wordlist)
        {
            Console.WriteLine(word);
        }
    }

    public static char[] getInput()
    {
        Console.WriteLine("Input letters in format: Abcdefg (Where A is the central letter)");
        char[] letters = Console.ReadLine().ToLower().ToCharArray();
        while (validateInput(letters) == false)
        {
            return getInput();
        }
        return letters;
    }

    public static bool validateInput(char[] letters)
    {
        if (letters == null || letters.Length != nletters)
        {
            Console.WriteLine("Invalid input, enter " + nletters + " letters");
            return false;
        }
        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] < 'a' || letters[i] > 'z') //Checks if inputted elements are between a and z (Char.IsLetter allows letters not within the english alphabet)
            {
                Console.WriteLine("Invalid input, no symbols or numbers");
                return false;
            }
        }
        string sletters = new string(letters);
        Console.WriteLine("Is this correct: " + char.ToUpper(sletters[0]) + sletters.Substring(1) + " [Y/N] \nWhere the capitalised letter is central");
        string answer = Console.ReadLine().ToUpper();
        while (!answer.Equals("Y") && !answer.Equals("N"))
        {
            answer = Console.ReadLine().ToUpper();
        }
        if (answer.Equals("N"))
        {
            return false;
        }
        return true;
        
    }

}