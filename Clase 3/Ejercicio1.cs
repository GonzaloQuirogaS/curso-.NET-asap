using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_3
{
    internal class Ejercicio1
    {
        string[] web = { "Inicio", "Productos", "Contacto" };
        public void getSecciones()
        {
            foreach (string seccion in web)
            {
                Console.WriteLine("Seccion: " + seccion);
            }
        }
    }
}
