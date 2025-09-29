// See https://aka.ms/new-console-template for more information

using Hangman_Game;

internal class Program
{
    private static void Main(string[] args)
    {

        UIFacade.UIFacade facade = new UIFacade.UIFacade();

        Console.WriteLine("Escolha uma categoria:");
        Console.WriteLine("1. Animals");
        Console.WriteLine("2. Games");
        Console.WriteLine("3. Software");
        Console.WriteLine("4. Sports");
        Console.WriteLine("5. ProgrammingLanguages");

        Console.Write("Digite o número da categoria: ");
        string entrada = Console.ReadLine();
        int escolha = int.Parse(entrada);

        string categoria = "";

        switch (escolha)
        {
            case 1:
                categoria = "Animals";
                break;
            case 2:
                categoria = "Games";
                break;
            case 3:
                categoria = "Software";
                break;
            case 4:
                categoria = "Sports";
                break;
            case 5:
                categoria = "ProgrammingLanguages";
                break;
            default:
                Console.WriteLine("Escolha inválida.");
                return;
        }

        facade.StartGame(categoria);

        while (true)
        {
            Console.WriteLine("Digite uma letra: ");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                char letra = input[0];
                facade.PlayTurn(letra);
            }

            facade.ShowStatus();

        }

    }

}