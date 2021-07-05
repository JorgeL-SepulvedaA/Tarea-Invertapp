using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertApp
{
    class Repositorio
    {
        public static Repositorio Enlistar { get; } = new Repositorio();

        public List<Categorias> ListadoCategorias { get; set; } = new List<Categorias>();
        public List<Productos> ListadoProductos { get; set; } = new List<Productos>();
    }
}
