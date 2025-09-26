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
            
        }

        public void ShowStatus()
        {
          
        }

        public void Restart(string category)
        {
            
        }
    }

}
