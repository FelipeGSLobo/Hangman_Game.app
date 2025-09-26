namespace Hangman_Game
{
    internal class EsportesFactory : WordCreatorFactory
    {
        public override IWordCreator CreateWordCreator()
        {
            return new SportsCategory();
        }
    }
}
