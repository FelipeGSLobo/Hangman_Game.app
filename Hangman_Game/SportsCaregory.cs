namespace Hangman_Game
{
    internal class SportsCategory : IWordCreator
    {
        public Word CreateWordList()
        {
            return CallAPI.GetInstance().GetWord("sports","pt-br").Result;
        }

        public string getCategories()
        {
            return "Esportes";
        }
    }
}
