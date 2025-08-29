using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_2
{
    internal class Ejercicio5
    {
        static void Main()
        {
            string USER = "admin";
            string PASS = "1234";

            int counter = 1;

            do
            {
                Console.Write("Ingrese su nombre de usuario: ");
                string usuario = Console.ReadLine();
                Console.Write("Ingrese su contraseña: ");
                string password = Console.ReadLine();
                if (usuario == USER && password == PASS)
                {
                    Console.WriteLine("\n+---------------------------------------------+");
                    Console.WriteLine("|              Acceso concedido               |");
                    Console.WriteLine("+---------------------------------------------+\n");

                    break;
                }
                else
                {
                    Console.WriteLine("\n+-------------- Acceso denegado --------------+");
                    Console.WriteLine("|             Le quedan " + (3 - counter) + " intentos            |");
                    Console.WriteLine("+---------------------------------------------+\n");

                    counter++;
                }
            }
            while (counter <= 3);
        }

    }
}
