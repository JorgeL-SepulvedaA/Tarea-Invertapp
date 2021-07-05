using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertApp
{
    class MenuPrincipal : IMenus
    {
        public string Opcion1 { get; } = "1. Mantenimientos de categorías.";
        public string Opcion2 { get; } = "2. Mantenimientos de productos.";
        public string Opcion3 { get; } = "3. Entrada de inventario.";
        public string Opcion4 { get; } = "4. Salida de inventario.";
        public string Opcion5 { get; } = "5. Salir.";

        public void MostrarMenu()
        {
            Console.Clear();

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
                    EntradaInventario();
                    break;

                case (int)EnumMenuPrincipal.SalidaInventario:
                    SalidaInventario();
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
        public void EntradaInventario()
        {
            Console.Clear();

            IMetodosMantenimiento metodosMantenimiento = new MantenimientoProductos();

            metodosMantenimiento.Listar();

            Console.WriteLine("Digite el indice del producto a registrar entrada:");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El producto {Repositorio.Enlistar.ListadoProductos[index - 1].Nombre}" +
                $" tiene una cantidad de {Repositorio.Enlistar.ListadoProductos[index - 1].Cantidad}\n" +
                $"Digite la cantidad a añadir:");
            int nuevaCantidad = Convert.ToInt32(Console.ReadLine());
            int antiguaCantidad = Repositorio.Enlistar.ListadoProductos[index - 1].Cantidad;

            Repositorio.Enlistar.ListadoProductos[index - 1].Cantidad = nuevaCantidad + antiguaCantidad;

            Console.WriteLine("Cantidad añadida exitosamente... Pulse cualquier tecla para continuar.");
            Console.ReadKey();
            MostrarMenu();

        }
        public void SalidaInventario()
        {
            Console.Clear();

            IMetodosMantenimiento metodosMantenimiento = new MantenimientoProductos();

            metodosMantenimiento.Listar();

            Console.WriteLine("Digite el indice del producto a registrar entrada:");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El producto {Repositorio.Enlistar.ListadoProductos[index - 1].Nombre}" +
                $" tiene una cantidad de {Repositorio.Enlistar.ListadoProductos[index - 1].Cantidad}\n" +
                $"Digite la cantidad a restar:");
            int nuevaCantidad = Convert.ToInt32(Console.ReadLine());
            int antiguaCantidad = Repositorio.Enlistar.ListadoProductos[index - 1].Cantidad;

            switch(nuevaCantidad > antiguaCantidad)
            {
                case true:
                    Console.WriteLine("La cantidad a sustraer excede la cantidad existente... Pulse cualquier tecla para continuar");
                    Console.ReadKey();

                    break;

                case false:
                    Repositorio.Enlistar.ListadoProductos[index - 1].Cantidad = nuevaCantidad - antiguaCantidad;

                    Console.WriteLine("Cantidad añadida exitosamente... Pulse cualquier tecla para continuar.");
                    Console.ReadKey();
                    MostrarMenu();

                    break;
            }

            
        }
    }
}
