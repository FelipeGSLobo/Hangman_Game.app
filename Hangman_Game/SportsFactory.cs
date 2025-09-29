namespace Hangman_Game
{
    internal class SportsFactory : WordCreatorFactory
    {
        public override IWordCreator CreateWordCreator()
        {
            return new SportsCategory();
        }
    }
}
