using System.Text;

namespace Hangman_Game;

public class Word
{
    public string word { get; set; }         
    public int length { get; set; }           
    public string category { get; set; }      
    public string language { get; set; }

    public string EntireWord
    {
        get { return word.ToUpper(); }
    }

    public bool ContainsLetter(char letter)
    {
        return word.IndexOf(letter, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    public string GetWord(List<char> guessedLetters)
    {
        var masked = new StringBuilder();

        foreach (char c in word)
        {
            if (guessedLetters.Contains(char.ToLowerInvariant(c)))
                masked.Append(c);
            else
                masked.Append('_');
        }

        return masked.ToString();
    }
}
