namespace Hangman_Game
{
    internal class GamesCategory : IWordCreator
    {
        private Word palavra;

        public Word CreateWordList()
        {
            return CallAPI.GetInstance().GetWord("games","en").Result;
        }

        public string getCategories()
        {
            return "Jogos";
        }

        public Word GetWord()
        {
            return palavra;
        }
    }
}