namespace Hangman_Game
{
    internal class SoftwareCategory : IWordCreator
    {
        public SoftwareCategory Category { get; set; }

        public override Word CreateWordList()
        {
            return CallAPI.getInstance().GetWord("softwares","en").Result;
        }

        public string GetCategories()
        {
            return "Software";
        }
    }
}