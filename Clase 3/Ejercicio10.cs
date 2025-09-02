using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_3
{
    internal class Ejercicio10
    {
        Stack<string> historial = new Stack<string>();

        public void getHistorial()
        {
            string opcion;

            Console.WriteLine("Historial de navegación.");
            Console.WriteLine("Opciones disponibles: \n1. Navegar \n2. Retroceder  \n3. Salir");

            do
            {
                Console.Write("\nIngrese opcion: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese la URL: ");
                        string url = Console.ReadLine();
                        historial.Push(url);
                        Console.WriteLine("Navegaste a: " + url);
                        break;

                    case "2":
                        if (historial.Count > 1)
                        {
                            historial.Pop();
                            Console.WriteLine("Retrocediste a: " + historial.Peek());
                        }
                        else if (historial.Count == 1)
                        {
                            historial.Pop();
                            Console.WriteLine("Historial vacío");
                        }
                        else
                        {
                            Console.WriteLine("No hay historial para retroceder");
                        }
                        break;

                    case "3":
                        break;

                    default:
                        Console.WriteLine("Comando incorrecto");
                        break;
                }

            } while (opcion != "3");
        }
    }
}


