using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_2
{
    internal class Ejercicio6
    {
        /*
        static void Main()
        {
            Console.WriteLine("Ingrese una frase:");
            string frase = Console.ReadLine();

            string frase_final = "";
            bool espacioAnterior = false;

            for (int i = 0; i < frase.Length; i++)
            {
                char c = frase[i];

                if (c == ' ')
                {
                    if (!espacioAnterior)
                    {
                        frase_final += ' ';
                        espacioAnterior = true;
                    }
                }
                else
                {
                    frase_final += char.ToLower(c);
                    espacioAnterior = false;
                }
            }

            frase_final = frase_final.Trim();

            if (frase_final.Length > 0)
            {
                frase_final = char.ToUpper(frase_final[0]) + frase_final.Substring(1);
            }

            Console.WriteLine("\nFrase formateada:");
            Console.WriteLine(frase_final);
        }
        */
    }
}

