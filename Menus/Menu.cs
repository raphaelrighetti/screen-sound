using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class Menu
    {
        public Menu(string titulo)
        {
            Titulo = titulo;
        }

        private string Titulo { get; set; }

        public virtual void Executar()
        {
            Console.Clear();
            ExibirTitulo();
        }

        private void ExibirTitulo()
        {
            string asteriscos = string.Empty.PadLeft(Titulo.Length, '*');

            Console.WriteLine(asteriscos);
            Console.WriteLine(Titulo);
            Console.WriteLine(asteriscos);

            Console.WriteLine();
        }
    }
}
