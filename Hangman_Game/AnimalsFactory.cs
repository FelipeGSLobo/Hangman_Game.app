namespace Hangman_Game
{
    internal class AnimalsFactory : WordCreatorFactory
    {
        public override IWordCreator CreateWordCreator()
        {
            return new AnimalsCategory();
        }
    }
}
