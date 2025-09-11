using Ejercicios.Clase_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class MainClass
    {
        public static void Main()
        {
            ejerciciosClase4();
        }

        public static void ejerciciosClase4()
        {
            bool aux = true;
            while (aux)
            {
                Console.WriteLine("\n+------------------------------------------------------+");
                Console.WriteLine("|  1. Clase Persona                                    |");
                Console.WriteLine("|  2. Metodos en clases                                |");
                Console.WriteLine("|  3. Constructores                                    |");
                Console.WriteLine("|  4. Clase Estudiante                                 |");
                Console.WriteLine("|  5. Clase Profesor                                   |");
                Console.WriteLine("|  6. Uso de herencia en acción                        |");
                Console.WriteLine("|  7. Método polimórfico                               |");
                Console.WriteLine("|  8. Polimorfismo con parámetros                      |");
                Console.WriteLine("|  9. Interfaz IUsuario                                |");
                Console.WriteLine("| 10. Múltiples interfaces                             |");
                Console.WriteLine("| 11. Clase abstracta Animal                           |");
                Console.WriteLine("| 12.  Sistema de pago (abstracto + polimorfismo)      |");
                Console.WriteLine("| 13. Sistema de Roles en una Aplicación Web           |");
                Console.WriteLine("| 14. Carrito de Compras con Interfaces                |");
                Console.WriteLine("| 15. Sistema de Pagos Extensible                      |");
                Console.WriteLine("+------------------------------------------------------+\n");

                Console.Write("Opcion: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Persona persona = new Persona("Gonzalo", 24);
                        persona.verPersona();
                        break;
                    case "2":
                        Persona persona1 = new Persona("Gonzalo", 24);
                        persona1.Saludar();
                        break;
                    case "3":
                        Persona persona2 = new Persona("Gonzalo", 24);
                        Persona persona3 = new Persona("Pepe", 43);
                        persona2.verPersona();
                        persona3.verPersona();
                        break;
                    case "4":
                        Estudiante estudiante = new Estudiante("Gonzalo", 24, "Sistemas");
                        estudiante.Estudiar();
                        break;
                    case "5":
                        Profesor profesor = new Profesor("Steve", 50, "BBDD");
                        profesor.Enseñar();
                        break;
                    case "6":
                        Profesor profesor1 = new Profesor("Steve", 50, "BBDD");
                        Estudiante estudiante1 = new Estudiante("Gonzalo", 24, "Sistemas");
                        estudiante1.Presentarse();
                        estudiante1.Estudiar();
                        profesor1.Presentarse();
                        profesor1.Enseñar();
                        break;
                    case "7":
                        List<Persona> personas = new List<Persona>();

                        personas.Add(new Estudiante("Gonzalo", 24, "Sistemas"));
                        personas.Add(new Estudiante("Luis", 25, "Sistemas"));
                        personas.Add(new Profesor("Tadeo", 55, "BBDD"));

                        foreach (Persona p in personas)
                        {
                            p.Presentarse();

                        }
                        break;
                    case "8":
                        Sistema sistema = new Sistema();
                        sistema.MostrarInfo(new Profesor("Tomas", 55, "BBDD"));
                        sistema.MostrarInfo(new Estudiante("Gonzalo", 24, "Sistemas"));
                        break;
                    case "9":
                        Profesor profesor2 = new Profesor("Tomas", 55, "BBDD");
                        Estudiante estudiante2 = new Estudiante("Gonzalo", 24, "Sistemas");

                        profesor2.Login();
                        estudiante2.Login();
                        break;
                    case "10":
                        Profesor profesor3 = new Profesor("Tomas", 55, "BBDD");
                        profesor3.Login();
                        profesor3.Notificar("Inicio de sesion exitoso");
                        break;
                    case "11":
                        List<Animal> animales = new List<Animal>();
                        animales.Add(new Perro());
                        animales.Add(new Perro());
                        animales.Add(new Perro());
                        animales.Add(new Perro());
                        animales.Add(new Gato());
                        animales.Add(new Gato());
                        animales.Add(new Gato());

                        foreach (Animal animal in animales)
                        {
                            animal.HacerSonido();
                        }
                        break;
                    case "12":
                        Pago pagoTajeta = new PagoTarjeta();
                        Pago pagoPaypal = new PagoPaypal();

                        pagoTajeta.ProcesarPago(500);
                        pagoPaypal.ProcesarPago(300);
                        break;
                    case "13":
                        List<UsuarioWeb> usuarios = new List<UsuarioWeb>();
                        usuarios.Add(new Cliente("Gonzalo", "gonzalo@email.com"));
                        usuarios.Add(new Cliente("Pepe", "pepe@email.com"));
                        usuarios.Add(new Administrador("Lucas", "lucas@email.com"));

                        foreach (UsuarioWeb usuario in usuarios)
                        {
                            usuario.AccederPanel();
                        }
                        break;

                    case "14":
                        Carrito carrito = new Carrito();
                        carrito.productos.Add(new Libro("Harry Potter", 30000, "J.K. Rowling"));
                        carrito.productos.Add(new Libro("El principito", 14000, "Antoine de Saint-Exupéry"));
                        carrito.productos.Add(new Videojuego("League of Legends", 0, "PC"));
                        carrito.productos.Add(new Videojuego("Minecraft", 20000, "PC, XBOX, PS4, PS5, Nintendo Switch"));
                        carrito.productos.Add(new Videojuego("CS2", 0, "PC"));
                        carrito.productos.Add(new Videojuego("Hollow Knigth", 10000, "XBOX, PC, PS5, Nintendo Switch"));

                        carrito.MostrarDetalle();
                        Console.WriteLine($"\nTotal a pagar: ${carrito.CalcularTotal()}");
                        break;

                    case "15":
                        List<Pago> pagos = new List<Pago>();
                        pagos.Add(new PagoTarjeta());
                        pagos.Add(new PagoTarjeta());
                        pagos.Add(new PagoPaypal());
                        pagos.Add(new PagoPaypal());
                        pagos.Add(new PagoPaypal());

                        double[] montos = { 560, 220, 300, 553, 876 };

                        for (int i = 0; i < pagos.Count; i++)
                        {
                            Pago pago = pagos[i];
                            double monto = montos[i];

                            pago.ProcesarPago(monto);

                            if (pago is INotificable notificable)
                            {
                                notificable.Notificar("Pago realizado con exito");
                            }

                            Console.WriteLine();
                        }
                        break;
                    case "0":
                        aux = false;
                        break;
                }
            }
        }
    }
}
