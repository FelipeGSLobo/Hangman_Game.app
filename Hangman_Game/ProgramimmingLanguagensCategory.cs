namespace Hangman_Game
{
    internal class ProgramimmingLanguagensCategory : IWordCreator
    {
        public Word CreateWordList()
        {
            return CallAPI.GetInstance().GetWord("programming_languages","en").Result;
        }

        public string getCategories()
        {
            return "Animais";
        }
    }
}
