using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicios.Clase_4
{
    class Estudiante : Persona, IUsuario
    {
        public string carrera;

        public Estudiante(string nombre, int edad, string carrera) : base(nombre, edad)
        {
            this.carrera = carrera;
        }

        public void Estudiar()
        {
            Console.WriteLine($"{nombre} esta estudiando {carrera}.");
        }

        public void Login()
        {
            while (true)
            {
                Console.Write("Ingrese su usuario: ");
                string nombreUsuario = Console.ReadLine();

                Console.Write("Ingrese su contraseña: ");
                Console.ReadLine();

                if (nombreUsuario.Trim() != null && nombreUsuario.ToLower() == nombre.ToLower())
                {
                    Console.WriteLine($"Bienvenido estudiante {nombre}");
                    break;
                }
                else
                {
                    Console.WriteLine("Error al iniciar sesion.");
                }
            }
        }
    }
}
