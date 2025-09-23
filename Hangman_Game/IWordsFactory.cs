namespace Hangman_Game
{
    internal interface IWordCreator
    {
        Category Category { get; set; }

         public Word CreateWordList();

        public string getCategories();
    }
}
