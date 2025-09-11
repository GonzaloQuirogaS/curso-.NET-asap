using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_4
{
    internal class Administrador : UsuarioWeb
    {
        string nombre;
        string correo;

        public Administrador(string nombre, string correo) : base(nombre, correo)
        {
            this.nombre = nombre;
            this.correo = correo;
        }

        public override void AccederPanel()
        {
            Console.WriteLine("\n+--------------------------------+");
            Console.WriteLine($" - Panel de control de: {nombre}  ");
            Console.WriteLine($" - Mail: {correo}                 ");
            Console.WriteLine("+--------------------------------+");
        }
    }
}
