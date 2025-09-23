namespace Hangman_Game;

public class Match
{
    protected static Match? instance = null;
    
    public Word Word {get; set;}
    public List<Char> TriedLetters {get; set;}
    public int TriesCount {get; set;}
    
    
    private Match()
    {
        TriedLetters = new List<char>();
        TriesCount = 6;
    }

    public static Match GetInstance()
    {
        return instance ??= new Match();
    }

    public void StartMatch(Word word)
    {
        this.Word = word;
        this.TriedLetters.Clear();
    }

    public bool Gamble(Char character)
    {
        
        char letter = char.ToUpper(character);
        
        if (TriedLetters.Contains(letter))
        {
            Console.WriteLine($"Já houve uma tentativa para a letra: \"{letter}\"...");
            return false;
        }
        
        this.TriedLetters.Add(letter);

        if (!Word.EntireWord.Contains(letter, StringComparison.OrdinalIgnoreCase))
        {
            TriesCount--;
            
            if (TriesCount <= 0)
            {
                Console.WriteLine("Game Over");
                Console.WriteLine("Você esgotou suas tentativas... Boa sorte na proxima!");
            }
            
            return false;
        }
        
        return true;
    }
    
    public string GetWordProgress()
    {
        var progress = Word.EntireWord
            .Select(c => TriedLetters.Contains(c) ? c : '_')
            .ToArray();
        return string.Join(" ", progress);
    }
}