using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_3
{
    internal class Ejercicio9
    {
        HashSet<string> instagram = new HashSet<string> { "gonzalo", "matias", "lucas", "miguel", "rafael" };
        HashSet<string> facebook = new HashSet<string> { "gonzalo", "pepe", "joaquin", "miguel", "francisco" };



        public void usuariosEnAmbasRedes()
        {
            HashSet<string> usuariosEnAmbas = new HashSet<string>(instagram);
            usuariosEnAmbas.IntersectWith(facebook);

            Console.WriteLine("Usuarios registrados en ambas redes sociales:");
            foreach (string usuario in usuariosEnAmbas)
            {
                Console.WriteLine(usuario);
            }
        }
    }
}
