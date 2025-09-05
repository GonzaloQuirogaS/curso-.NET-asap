using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicios.Clase_3
{
    internal class Ejercicio11
    {
        private bool validarEtiqueta(string html)
        {
            Stack<string> cadena = new Stack<string>();

            Regex regex = new Regex(@"</?([a-zA-Z0-9]+)>");
            MatchCollection matches = regex.Matches(html);

            foreach (Match match in matches)
            {
                string etiquetaCompleta = match.Value;
                string nombreEtiqueta = match.Groups[1].Value;

                if (!etiquetaCompleta.StartsWith("</"))
                {
                    cadena.Push(nombreEtiqueta);
                }
                else
                {
                    if (cadena.Count == 0 || cadena.Peek() != nombreEtiqueta)
                    {
                        return false;
                    }
                    cadena.Pop();
                }
            }
            return cadena.Count == 0;
        }

        public void mostrarMensaje(string html)
        {
            if (validarEtiqueta(html))
            {
                Console.WriteLine("Es valido");
            }
            else
            {
                Console.WriteLine("No es valido");
            }
        }
    }
}
