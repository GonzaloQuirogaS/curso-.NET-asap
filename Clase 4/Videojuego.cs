using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicios.Clase_4
{
    internal class Videojuego : IProducto
    {
        public string nombre { get; set; }
        public double precio { get; set; }

        public string plataforma { get; set; }

        public Videojuego(string nombre, double precio, string plataforma)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.plataforma = plataforma;
        }

        public override string ToString()
        {
            return $"Videojuego: {nombre} - Plataforma: {plataforma} - Precio: ${precio}";
        }
    }
}
