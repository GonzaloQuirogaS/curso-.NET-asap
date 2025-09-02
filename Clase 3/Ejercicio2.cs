using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_3
{
    internal class Ejercicio2
    {
        string[] URLs = {
            "www.google.com",
            "www.facebook.com",
            "www.promiedos.com",
            "www.instagram.com",
            "www.promiedos.com",
            "www.github.com",
            "www.accuweather.com",
            "www.gamestorrent.com",
            "www.mercadolibre.com",
            "www.youtube.com"
        };

        public void contiene(string palabra)
        {
            for (int i = 0; i < URLs.Length; i++)
            {
                if (URLs[i].Contains(palabra))
                {
                    Console.WriteLine("La URL " + URLs[i] + " en la posicion " + i + " contiene la palabra ingresada " + palabra);
                }
            }
        }

    }
}
