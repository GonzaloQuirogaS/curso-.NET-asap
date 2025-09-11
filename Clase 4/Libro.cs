using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicios.Clase_4
{
    internal class Libro : IProducto
    {
        public string nombre { get; set; }
        public double precio { get; set; }

        public string autor { get; set; }
        public Libro(string nombre, double precio, string autor)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.autor = autor;
        }

        public override string ToString()
        {
            return $"Libro: {nombre} - Autor: {autor} - Precio: ${precio}";
        }
    }
}
