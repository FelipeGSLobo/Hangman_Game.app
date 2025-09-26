// See https://aka.ms/new-console-template for more information

using Hangman_Game;

internal class Program
{
    private static void Main(string[] args)
    {
        WordCreatorFactory factory = new AnimalsFactory();

        IWordCreator animal = factory.CreateWordCreator();

        animal.getCategories();
        animal.CreateWordList();
    }
}