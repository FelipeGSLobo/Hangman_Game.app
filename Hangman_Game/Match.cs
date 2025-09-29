namespace Hangman_Game;

public class Match
{
    protected static Match? instance = null;
    
    public Word word {get; private set;}
    public List<Char> TriedLetters {get; set;}
    public int TriesCount {get; set;}

    public void SetWord(Word palavra)
    {
        word = palavra;
    }

    private Match()
    {
        TriedLetters = new List<char>();
        TriesCount = 6;
    }

    public static Match GetInstance()
    {
        if(instance == null)
        {
            instance = new Match();
        }
       
           return instance;
    }

    public void StartMatch(Word word)
    {
        this.word = word;
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

        if (!word.EntireWord.Contains(letter, StringComparison.OrdinalIgnoreCase))
        {
            TriesCount--;
            
            if (TriesCount < 1)
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
        string resultado = "";

        foreach (char letra in word.EntireWord)
        {
            // Normaliza a letra da palavra para minúsculo
            char letraNormalizada = char.ToLowerInvariant(letra);

            // Verifica se a letra normalizada está entre as tentadas (também normalizadas)
            if (TriedLetters.Any(l => char.ToLowerInvariant(l) == letraNormalizada))
            {
                resultado += letra + " "; // exibe a letra original (com acento ou maiúscula)
            }
            else
            {
                resultado += "_ ";
            }
        }

        return resultado.Trim();
    }

}