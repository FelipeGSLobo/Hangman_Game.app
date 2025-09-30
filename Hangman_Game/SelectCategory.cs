using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Game
{
    class SelectCategory
    {
        WordCreatorFactory factory;
        IWordCreator creator;

        public void selectCategory(String category)
        {
            switch (category)
            {
                case "Animals":
                    factory = new AnimalsFactory();
                    break;

                case "Games":
                    factory = new GamesFactory();
                    break;

                case "Software":
                    factory = new SoftwareFactory();
                    break;

                case "Sports":
                    factory = new SportsFactory();
                    break;

                case "ProgrammingLanguages":
                    factory = new ProgramimmingLanguagensFactory();
                    break;
            }

            creator = factory.CreateWordCreator();
            creator.getCategories();
            creator.CreateWordList();

            Word palavra = creator.GetWord();

            if (palavra == null)
            {
                Console.WriteLine("Erro ao obter palavra da categoria selecionada.");
                return;
            }

            Match.GetInstance().StartMatch(palavra);
        }
    }
}
