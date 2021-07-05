using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertApp
{
    class MantenimientoCategorias : IMetodosMantenimiento
    {
        public void Agregar()
        {
            Console.Clear();

            Console.WriteLine("Digite el nombre de la categoria que desee agregar:");
            string nombreCategoria = Console.ReadLine();

            Categorias categoria = new Categorias(nombreCategoria);

            Repositorio.Enlistar.ListadoCategorias.Add(categoria);

            Console.WriteLine("Agregado con exito, pulse cualquier tecla para continuar.");
            Console.ReadKey();

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

            Console.WriteLine("Digite el indice de la categoria a editar:");
            int indice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El valor del índice señalado es: {Repositorio.Enlistar.ListadoCategorias[indice]}\n" +
                $"Digite el nuevo valor:");
            Categorias categoria = new Categorias(Console.ReadLine());

            Repositorio.Enlistar.ListadoCategorias.RemoveAt(indice-1);
            Repositorio.Enlistar.ListadoCategorias.Insert(indice-1, categoria);
        }
        public void Eliminar()
        {
            Console.Clear();

            Listar();

            Console.WriteLine("Digite el indice de la categoria a eliminar:");
            int indice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El valor del índice señalado es: {Repositorio.Enlistar.ListadoCategorias[indice]}\n" +
                $"¿Desea eliminarlo?\n" +
                "<S>SI\n" +
                "<N>NO");
            char eliminar = Convert.ToChar(Console.ReadLine());

            switch (char.ToLower(eliminar))
            {
                case 's':
                    Repositorio.Enlistar.ListadoCategorias.RemoveAt(indice - 1);
                    Console.WriteLine("Categoria eliminada exitosamente.\nPulse cualquier tecla para continuar.");
                    Console.ReadKey();
                    break;
                case 'n':
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
            int index = 0;

            foreach(Categorias categoria in Repositorio.Enlistar.ListadoCategorias)
            {
                Console.WriteLine($"{index + 1}- {categoria}.");
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
