using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicios.Clase_4
{
    internal class Persona
    {
        public string nombre;
        public int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }



        public void verPersona()
        {
            Console.WriteLine(nombre);
            Console.WriteLine(edad);
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola soy {nombre} y tengo {edad} años");
        }


        virtual public void Presentarse()
        {
            Console.WriteLine($"Hola soy {nombre} y tengo {edad} años");
        }

    }

}
