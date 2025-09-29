namespace Hangman_Game
{
    internal class GamesCategory : IWordCreator
    {
        private Word palavra;

        public Word CreateWordList()
        {
            palavra =  CallAPI.GetInstance().GetWord("games","en").Result;
            return palavra;
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