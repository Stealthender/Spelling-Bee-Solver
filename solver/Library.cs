public class LibraryClass
{
    //This class reduces the wordlists to only valid words, by removing words that contain characters not in the input
    public static string[] library(char[] letters)
    {
        List<string> words = new List<string>();
        string word;

        using StreamReader reader = new("C:/Users/zerte/OneDrive/Documents/GitHub/Spelling-Bee-Solver/wordlist/wordlist.txt");
        while((word = reader.ReadLine()) != null)
        {
            bool isvalid = isValid(word, letters);
            if(isvalid == true)
            {
                words.Add(word);
            }
        }
        reader.Close();
        return words.ToArray();
    }
    public static bool isValid(string word, char[] letters)
    {
        char[] wordarray = word.ToCharArray();
        for (int x = 0; x < wordarray.Length; x++)
        {
            if (!letters.Contains(wordarray[x])) //Check if the current letter is not in the accepted letters
            {
                return false;
            }
        }
        if (!wordarray.Contains(letters[0])) //Checks if the central letter is in the word
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}