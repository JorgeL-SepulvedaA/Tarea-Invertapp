using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertApp
{
    class MenuCategorias : IMenus
    {
        public string Opcion1 { get; } = "1. Agregar";
        public string Opcion2 { get; } = "2. Editar";
        public string Opcion3 { get; } = "3. Eliminar";
        public string Opcion4 { get; } = "4. Listar";
        public string Opcion5 { get; } = "5. Volver";



        public void MostrarMenu()
        {
            Console.Clear();

            Console.WriteLine($">MENÚ DE MANTENIMIENTO DE CATEGORIAS<\n" +
                $"{this.Opcion1}\n" +
                $"{this.Opcion2}\n" +
                $"{this.Opcion3}\n" +
                $"{this.Opcion4}\n" +
                $"{this.Opcion5}\n\n" +
                "Elija la opcion que desea:");
            int opcion = Convert.ToInt32(Console.ReadLine());


            IMetodosMantenimiento metodosMantenimiento = new MantenimientoCategorias();

            switch (opcion)
            {
                case (int)EnumMantenimientos.Agregar:
                    metodosMantenimiento.Agregar();
                    MostrarMenu();
                    break;

                case (int)EnumMantenimientos.Editar:
                    metodosMantenimiento.Editar();
                    MostrarMenu();
                    break;

                case (int)EnumMantenimientos.Eliminar:
                    metodosMantenimiento.Eliminar();
                    MostrarMenu();
                    break;

                case (int)EnumMantenimientos.Listar:
                    metodosMantenimiento.Listar();
                    Console.WriteLine("Pulse cualquier tecla para continuar...");
                    Console.ReadKey();
                    MostrarMenu();
                    break;

                case (int)EnumMantenimientos.Volver:
                    metodosMantenimiento.Volver();
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
