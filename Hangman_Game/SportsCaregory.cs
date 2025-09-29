namespace Hangman_Game
{
    internal class SportsCategory : IWordCreator
    {
        private Word palavra;
        public Word CreateWordList()
        {
            palavra = CallAPI.GetInstance().GetWord("sports","pt-br").Result;
            return palavra;
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
