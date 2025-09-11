using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_4
{
    internal class Profesor : Persona, IUsuario, INotificable
    {

        public string materia;

        public Profesor(string nombre, int edad, string materia) : base(nombre, edad)
        {
            this.materia = materia;
        }

        public void Enseñar()
        {
            Console.WriteLine($"{nombre} enseña {materia}.");
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
                    Console.WriteLine($"Bienvenido profesor {nombre}");
                    break;
                }
                else
                {
                    Console.WriteLine("Error al iniciar sesion.");
                }
            }
        }

        public override void Presentarse()
        {
            base.Presentarse();
        }

        public void Notificar(string mensaje)
        {
            Console.WriteLine($"[Notificacion profesor] {mensaje}");
        }
    }
}
