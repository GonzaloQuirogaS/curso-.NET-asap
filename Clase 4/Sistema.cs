using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_4
{
    internal class Sistema
    {
        public void MostrarInfo(Persona p)
        {
            Console.WriteLine($"Nombre: {p.nombre}\nEdad: {p.edad}");
        }
    }
}
