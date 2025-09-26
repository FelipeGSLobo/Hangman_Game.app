namespace Hangman_Game
{
    internal class AnimalsCategory : IWordCreator
    {

        public Word CreateWordList()
        {
            return CallAPI.GetInstance().GetWord("animals","pt-br").Result;
        }

        public string getCategories()
        {
            return "Animais";
        }
    }
}
