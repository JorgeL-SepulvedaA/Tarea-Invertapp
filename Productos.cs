using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertApp
{
    class Productos
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }

        public Productos(string nombreProducto, double precioProducto, string categoriaProducto, int cantidadProducto)
        {
            this.Nombre = nombreProducto;
            this.Precio = precioProducto;
            this.Categoria = categoriaProducto;
            this.Cantidad = cantidadProducto;
        }
    }
}
