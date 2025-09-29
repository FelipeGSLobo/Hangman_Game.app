namespace Hangman_Game
{
    internal class AnimalsCategory : IWordCreator
    {
        private Word palavra;
        public Word CreateWordList()
        {
            palavra = CallAPI.GetInstance().GetWord("animals","pt-br").Result;
            return palavra;
        }

        public string getCategories()
        {
            return "Animais";
        }

        public Word GetWord()
        {
            return palavra;
        }
    }
}
