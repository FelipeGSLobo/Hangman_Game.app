namespace Hangman_Game
{
    internal interface IWordCreator
    {
        public Word CreateWordList();
        Word GetWord();
        public string getCategories();
    }
}
