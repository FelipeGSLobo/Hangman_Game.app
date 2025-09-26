namespace Hangman_Game
{
    internal class GamesCategory : IWordCreator
    {

        public Word CreateWordList()
        {
            return CallAPI.GetInstance().GetWord("games","en").Result;
        }

        public string getCategories()
        {
            return "Jogos";
        }
    }
}