using System;

namespace InvertApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("<Bienvenid@s a InvertApp>\n" +
                "Pulsa cualquier tecla para continuar...");
            Console.ReadKey();

            Console.Clear();

            MenuPrincipal menu = new MenuPrincipal();
            menu.MostrarMenu();
        }
    }
}
