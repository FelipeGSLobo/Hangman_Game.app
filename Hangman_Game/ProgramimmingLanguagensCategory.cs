namespace Hangman_Game
{
    internal class ProgramimmingLanguagensCategory : IWordCreator
    {
        public Category Category { get; set; }

        public override Word CreateWordList()
        {
            return CallAPI.getInstance().GetWord("programming_languages","en").Result;
        }

        public string GetCategories()
        {
            return "Animais";
        }
    }
}
