// See https://aka.ms/new-console-template for more information

using Hangman_Game;

internal class Program
{
    private static void Main(string[] args)
    {

        UIFacade.UIFacade facade = new UIFacade.UIFacade();
        facade.StartGame();

        while (Match.GetInstance().TriesCount != 0)
        {
            facade.ShowStatus();
            Console.WriteLine("\nDigite uma letra: ");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                char letra = input[0];
                facade.PlayTurn(letra);
            }
            
            if(facade.state())
                return;
        }
        facade.EndGame();
    }

}