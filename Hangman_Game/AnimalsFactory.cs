namespace Hangman_Game
{
    internal class AnimaisFactory : WordCreatorFactory
    {
        public override IWordCreator CreateWordCreator()
        {
            return new AnimaisCategory();
        }
    }
}
