namespace Hangman_Game
{
    internal class EsportesCategory : IWordCreator
    {
        public EsportesCategory Category { get; set; }

        public override Word CreateWordList()
        {
            return CallAPI.getInstance().GetWord("sports","pt-br").Result;
        }

        public string GetCategories()
        {
            return "Esportes";
        }
    }
}
