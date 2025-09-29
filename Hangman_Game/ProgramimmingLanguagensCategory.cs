namespace Hangman_Game
{
    internal class ProgramimmingLanguagensCategory : IWordCreator
    {

        private Word palavra;
        public Word CreateWordList()
        {
            palavra = CallAPI.GetInstance().GetWord("programming_languages","en").Result;
            return palavra;
        }

        public string getCategories()
        {
            return "Lingaugem de programação";
        }

        public Word GetWord()
        {
            return palavra;
        }
    }
}
