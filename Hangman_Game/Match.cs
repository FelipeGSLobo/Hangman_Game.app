namespace Hangman_Game;

public class Match
{
    protected static Match? instance = null;
    
    public Word Word {get; set;}
    public List<Char> TriesLetters {get; set;}
    public int TriesCount {get; set;}
    
    
    private Match(){}

    public static Match getInstance()
    {
        return instance ?? new Match();
    }

    public void startMatch(){}
    
    public void gamble(){}
    
    public void restartGame(){}
}