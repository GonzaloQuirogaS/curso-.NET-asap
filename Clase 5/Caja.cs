using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicios.Clase_5
{
    internal class Caja<T>
    {
        public T Contenido { get; set; }

        public Caja(T contenido)
        {
            Contenido = contenido;
        }

        public void MostrarContenido()
        {
            Console.WriteLine($"El contenido de la caja es: {Contenido}");
        }
    }
}
