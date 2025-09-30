using Hangman_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIFacade
{
    internal class UIFacade
    {
        private SelectCategory selectCategory;

        public UIFacade()
        {
            selectCategory = new SelectCategory();
        }

        public string Menu()
        {
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
                    return null;
            }
            
            return categoria;
        }
        public void StartGame()
        {
            string category = null;
            
            while (category == null)
            {
                category = Menu();
            }
            
            selectCategory.selectCategory(category);
            Console.WriteLine("O jogo começou!");
        }

        public void PlayTurn(char guess)
        {
            Console.Clear();
            var match = Match.GetInstance();
            bool tentativa = match.Gamble(guess);

            if (tentativa)
                Console.WriteLine("Acertou!");
            else 
                Console.WriteLine("Errou!");
        }

        public void ShowStatus()
        {
            var match = Match.GetInstance();

            if (match.TriesCount == 0) return;
            
            Console.WriteLine("Palavra: " + match.GetWordProgress());
            Console.WriteLine("Tentativas restantes: " + match.TriesCount);
        }

        public void EndGame()
        {
            Console.WriteLine("Fim de jogo!");
            Console.WriteLine("Deseja  jopgar novamente? s/n");
            
            string input = Console.ReadLine();

            if (input.ToUpper().Equals("S"))
            {
                StartGame();
            }
            return;
        }

        public bool state()
        {
            Match match = Match.GetInstance();
            return match.isChampion();
        }
    }

}
