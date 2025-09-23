namespace Hangman_Game
{
    internal class AnimaisCategory : IWordCreator
    {
        public Category Category { get; set; }

        public override Word CreateWordList()
        {
            return CallAPI.getInstance().GetWord("animal","pt-br");
        }

        public string GetCategories()
        {
            return;
        }
    }
}
