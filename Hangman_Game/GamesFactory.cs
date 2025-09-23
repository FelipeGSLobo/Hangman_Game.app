namespace Hangman_Game
{
    internal class GamesFactory : WordCreatorFactory
    {
        public override IWordCreator CreateWordCreator()
        {
            return new GamesFactory();
        }
    }
}
