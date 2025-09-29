namespace Hangman_Game
{
    internal class ProgramimmingLanguagensFactory : WordCreatorFactory
    {
        public override IWordCreator CreateWordCreator()
        {
            return new ProgramimmingLanguagensCategory();
        }
    }
}