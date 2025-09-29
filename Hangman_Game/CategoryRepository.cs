using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Game
{
    class CategoryRepository
    {
        private List<string> categorias;

        public CategoryRepository()
        {
            categorias = new List<string>
        {
            "animals",
            "games",
            "softwares",
            "sports"
        };
        }

        public List<string> GetCategorias()
        {
            return categorias;
        }

        public bool CategoriaExiste(string nome)
        {
            return categorias.Contains(nome.ToLower());
        }

    }
}
