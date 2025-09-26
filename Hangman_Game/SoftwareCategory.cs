namespace Hangman_Game
{
    internal class SoftwareCategory : IWordCreator
    {
        public Word CreateWordList()
        {
            return CallAPI.GetInstance().GetWord("softwares","en").Result;
        }

        public string getCategories()
        {
            return "Software";
        }
    }
}