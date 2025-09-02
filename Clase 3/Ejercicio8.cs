using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicios.Clase_3
{
    internal class Ejercicio8
    {
        HashSet<string> correos = new HashSet<string>();


        public void ingresarCorreos()
        {
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regexCorreo = new Regex(patronCorreo);

            Console.WriteLine("Ingrese correos electrónicos (escriba 'salir' para terminar): ");

            while (true)
            {
                Console.Write("\nCorreo: ");
                string correo = Console.ReadLine().ToLower().Trim();

                if (correo == "salir")
                {
                    break;
                }

                if (regexCorreo.IsMatch(correo))
                {

                    if (correos.Add(correo))
                    {
                        Console.WriteLine("\nCorreo agregado correctamente");
                    }
                    else
                    {

                        Console.WriteLine("\nCorreo ya ingresado");
                    }
                }
                else
                {
                    Console.WriteLine("\nCorreo invalido");
                }
            }

        }

        public void mostrarCorreos()
        {
            Console.WriteLine("\nLista de correos: ");
            foreach (string correo in correos)
            {
                Console.WriteLine(correo);
            }
        }
    }
}
