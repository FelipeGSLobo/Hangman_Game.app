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
        public void StartGame(string category)
        {
            selectCategory.selectCategory(category);
            Console.WriteLine("Game Started");
        }

        public void PlayTurn(char guess)
        {
            var match = Match.GetInstance();
            bool acertou = match.Gamble(guess);

            if (acertou)
                Console.WriteLine("Acertou!");
            else
                Console.WriteLine("Errou!");
        }

        public void ShowStatus()
        {
            var match = Match.GetInstance();
            Console.WriteLine("Palavra: " + match.GetWordProgress());
            Console.WriteLine("Tentativas restantes: " + match.TriesCount);
        }

        public void Restart(string category)
        {
            StartGame(category);
        }
    }

}
