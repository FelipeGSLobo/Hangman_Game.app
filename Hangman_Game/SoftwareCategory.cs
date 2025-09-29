namespace Hangman_Game
{
    internal class SoftwareCategory : IWordCreator
    {

        private Word palavra;
        public Word CreateWordList()
        {
            return CallAPI.GetInstance().GetWord("softwares","en").Result;
        }

        public string getCategories()
        {
            return "Software";
        }

        public Word GetWord()
        {
            return palavra;
        }
    }
}