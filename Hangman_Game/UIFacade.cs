using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIFacade
{
    internal class UIFacade
    {
        public void startGame()
        {
            Console.WriteLine("Game Started");
        }
        public void playTurn()
        {
            Console.WriteLine("Turn Played");
        }
        public void showStatus()
        {
            Console.WriteLine("Status Shown");
        }
        public void restart()
        {
            Console.WriteLine("Game Restarted");
        }
    }
}
