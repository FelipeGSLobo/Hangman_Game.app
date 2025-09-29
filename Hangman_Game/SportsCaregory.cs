namespace Hangman_Game
{
    internal class SportsCategory : IWordCreator
    {
        private Word palavra;
        public Word CreateWordList()
        {
            return CallAPI.GetInstance().GetWord("sports","pt-br").Result;
        }

        public string getCategories()
        {
            return "Esportes";
        }

        public Word GetWord()
        {
            return palavra;
        }
    }
}
