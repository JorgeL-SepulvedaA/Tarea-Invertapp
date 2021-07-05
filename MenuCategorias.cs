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
        public string Opcion2 { get; } = "1. Editar";
        public string Opcion3 { get; } = "1. Eliminar";
        public string Opcion4 { get; } = "1. Listar";
        public string Opcion5 { get; } = "1. Volver";



        public void MostrarMenu()
        {

            Console.WriteLine($">MENÚ DE MANTENIMIENTO DE PRODUCTOS<\n" +
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
                    break;

                case (int)EnumMantenimientos.Editar:
                    metodosMantenimiento.Editar();
                    break;

                case (int)EnumMantenimientos.Eliminar:
                    metodosMantenimiento.Eliminar();
                    break;

                case (int)EnumMantenimientos.Listar:
                    metodosMantenimiento.Listar();
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
