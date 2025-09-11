using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_4
{
    internal class Carrito
    {
        public List<IProducto> productos = new List<IProducto>();

        public double CalcularTotal()
        {
            double total = 0;

            foreach (IProducto producto in productos)
            {
                total += producto.precio;
            }
            return total;
        }

        public void MostrarDetalle()
        {
            foreach (IProducto producto in productos)
            {
                Console.WriteLine(producto.ToString());
            }
        }
    }
}
