using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertApp
{
    class MenuPrincipal : IMenus
    {
        public string Opcion1 { get; } = "1. Mantenimientos de categorías.r";
        public string Opcion2 { get; } = "2. Mantenimientos de productos.";
        public string Opcion3 { get; } = "3. Entrada de inventario.";
        public string Opcion4 { get; } = "4. Salida de inventario.";
        public string Opcion5 { get; } = "5. Salir.";

        public void MostrarMenu()
        {
            
            Console.WriteLine($">MENÚ PRINCIPAL<\n" +
                $"{this.Opcion1}\n" +
                $"{this.Opcion2}\n" +
                $"{this.Opcion3}\n" +
                $"{this.Opcion4}\n" +
                $"{this.Opcion5}\n\n" +
                "Elija la opcion que desea:");
            int opcion = Convert.ToInt32(Console.ReadLine());

            IMenus menu;

            switch (opcion)
            {
                case (int)EnumMenuPrincipal.MantenimientosCategorias:
                    menu = new MenuCategorias();
                    menu.MostrarMenu();
                    break;

                case (int)EnumMenuPrincipal.MantenimientosProductos:
                    menu = new MenuProductos();
                    menu.MostrarMenu();
                    break;

                case (int)EnumMenuPrincipal.EntradaInventario:
                    break;

                case (int)EnumMenuPrincipal.SalidaInventario:
                    break;

                case (int)EnumMenuPrincipal.Salir:
                    Console.Clear();

                    Console.Write("Esta bien, Adios... Pulse cualquier tecla para salir.");
                    Console.ReadKey();

                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();

                    Console.WriteLine("Opcion fuera de rango... Pulse cualquier tecla para volver a intentar.");
                    Console.ReadKey();

                    MostrarMenu();
                    break;
            }
        }
    }
}
