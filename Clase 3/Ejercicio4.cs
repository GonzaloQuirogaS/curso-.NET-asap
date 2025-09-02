using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_3
{
    internal class Ejercicio4
    {
        List<string> titulos = new List<string>();

        public void agregarTitulos()
        {

            Console.WriteLine("Ingrese titulos o 'salir' para terminar de ingresar");

            while (true)
            {
                Console.Write("Titulo: ");
                string titulo = Console.ReadLine();
                if (titulo.ToLower() == "salir")
                {
                    break;
                }
                if (titulo == "")
                {
                    Console.WriteLine("El titulo no puede estar vacio");
                    break;
                }
                titulos.Add(titulo);
            }
            titulos.Sort();

            for (int i = 0; i < titulos.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + titulos[i]);
            }
        }
    }
}
