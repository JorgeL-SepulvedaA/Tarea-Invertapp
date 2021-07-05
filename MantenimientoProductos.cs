using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertApp
{
    class MantenimientoProductos : IMetodosMantenimiento
    {
        public void Agregar()
        {
            Console.Clear();

            Console.WriteLine("Digite el nombre del producto:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Digite el precio del producto:");
            double precio = Convert.ToDouble(Console.ReadLine());

            MantenimientoCategorias mantenimientoCategorias = new();
            mantenimientoCategorias.Listar();

            Console.WriteLine("Digite el indice de la categoria del producto:");
            int indiceCategoria = Convert.ToInt32(Console.ReadLine());
            
            string categoria = Convert.ToString(Repositorio.Enlistar.ListadoCategorias[indiceCategoria-1].Nombre);

            Console.WriteLine("Digite la cantidad del producto:");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Productos producto = new Productos(nombre, precio, categoria, cantidad);
            Repositorio.Enlistar.ListadoProductos.Add(producto);

            Console.WriteLine("¿Desea seguir agregando?\n" +
                "<Z>SI\n" +
                "<X>NO");
            char seguir = Convert.ToChar(Console.ReadLine());

            switch (char.ToLower(seguir))
            {
                case 'z':
                    Agregar();
                    break;
                case 'x':
                    break;
            }
        } 
        public void Editar()
        {
            Console.Clear();

            Listar();

            Console.WriteLine("Digite el indice del producto a editar:");
            int indice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El nombre del índice señalado es: {Repositorio.Enlistar.ListadoProductos[indice-1].Nombre}\n" +
                $"Digite el nuevo valor:");
            string nombre = Console.ReadLine();

            Console.WriteLine($"El precio del índice señalado es: {Repositorio.Enlistar.ListadoProductos[indice-1].Precio}\n" +
                $"Digite el nuevo valor:");
            double precio = Convert.ToDouble(Console.ReadLine());

            MantenimientoCategorias mantenimientoCategorias = new();
            mantenimientoCategorias.Listar();

            Console.WriteLine($"La categoria del índice señalado es: {Repositorio.Enlistar.ListadoProductos[indice-1].Categoria}\n" +
                $"Digite el nuevo valor:");
            int indiceCategoria = Convert.ToInt32(Console.ReadLine());

            string categoria = Convert.ToString(Repositorio.Enlistar.ListadoCategorias[indiceCategoria - 1].Nombre);

            Console.WriteLine($"La cantidad del índice señalado es: {Repositorio.Enlistar.ListadoProductos[indice-1].Cantidad}\n" +
                $"Digite el nuevo valor:");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Productos producto = new Productos(nombre, precio, categoria, cantidad);

            Repositorio.Enlistar.ListadoProductos.RemoveAt(indice - 1);
            Repositorio.Enlistar.ListadoProductos.Insert(indice - 1, producto);

            Console.WriteLine("¿Desea seguir editando?\n" +
                "<Z>SI\n" +
                "<X>NO");
            char seguir = Convert.ToChar(Console.ReadLine());

            switch (char.ToLower(seguir))
            {
                case 'z':
                    Eliminar();
                    break;
                case 'x':
                    break;
            }
        }
        public void Eliminar()
        {
            Console.Clear();

            Listar();

            Console.WriteLine("Digite el indice del producto a eliminar:");
            int indice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El valor del índice señalado es: {Repositorio.Enlistar.ListadoProductos[indice-1].Nombre}\n" +
                $"¿Desea eliminarlo?\n" +
                "<S>SI\n" +
                "<N>NO");
            char eliminar = Convert.ToChar(Console.ReadLine());

            switch (char.ToLower(eliminar))
            {
                case 's':
                    Repositorio.Enlistar.ListadoProductos.RemoveAt(indice - 1);
                    Console.WriteLine("Categoria eliminada exitosamente.\nPulse cualquier tecla para continuar.");
                    Console.ReadKey();
                    break;
                case 'n':
                    break;
                default:
                    Console.WriteLine("Opcion invalida... pulse cualquier tecla para continuar.");
                    Console.ReadKey();
                    Eliminar();
                    break;
            }

            Console.WriteLine("¿Desea seguir eliminando?\n" +
                "<Z>SI\n" +
                "<X>NO");
            char seguir = Convert.ToChar(Console.ReadLine());

            switch (char.ToLower(seguir))
            {
                case 'z':
                    Eliminar();
                    break;
                case 'x':
                    break;
            }
        }
        public void Listar()
        {
            Console.Clear();

            int index = 0;

            foreach(Productos producto in Repositorio.Enlistar.ListadoProductos)
            {
                Console.WriteLine($"{index + 1}- {producto.Nombre}.");
                index++;
            }
        }
        public void Volver()
        {
            MenuPrincipal menuAnterior = new();
            menuAnterior.MostrarMenu();
        }
    }
}
