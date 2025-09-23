namespace Hangman_Game
{
    internal class SoftwareFactory : WordCreatorFactory
    {
        public override IWordCreator CreateWordCreator()
        {
            return new SoftwareFactory();
        }
    }
}
