namespace Hangman_Game
{
    internal class EsportesCategory : IWordCreator
    {
        public EsportesCategory Category { get; set; }

        public override Word CreateWordList()
        {
            return CallAPI.getInstance().GetWord("games","en").Result;
        }

        public string GetCategories()
        {
            return "Jogos";
        }
    }
}