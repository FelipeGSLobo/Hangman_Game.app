namespace Hangman_Game
{
    internal class AnimaisCategory : IWordCreator
    {
        public Category Category { get; set; }

        public override Word CreateWordList()
        {
            return CallAPI.getInstance().GetWord("animals","pt-br").Result;
        }

        public string GetCategories()
        {
            return "Animais";
        }
    }
}
