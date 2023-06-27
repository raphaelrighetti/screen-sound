using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuBemVindo : Menu
    {
        public MenuBemVindo(string titulo) : base(titulo)
        {
        }

        public override void Executar()
        {
            base.Executar();

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
