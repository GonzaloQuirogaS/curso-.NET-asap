using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_3
{
    internal class Ejercicio12
    {

        string contenidoStack = "";
        Stack<string> stack = new Stack<string>();

        public void escribir(string texto)
        {
            stack.Push(texto);
            contenidoStack += texto;
        }

        public void mostrarContenido()
        {
            Console.WriteLine("Contenido actual: " + contenidoStack);
        }

    }
}
