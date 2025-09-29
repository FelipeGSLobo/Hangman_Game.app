namespace Hangman_Game
{
    internal class SoftwareCategory : IWordCreator
    {

        private Word palavra;
        public Word CreateWordList()
        {
            palavra = CallAPI.GetInstance().GetWord("softwares","en").Result;
            return palavra;
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