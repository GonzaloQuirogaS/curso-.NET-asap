using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_5
{
    internal class Clase5
    {
        public void ejerciciosClase5()
        {
            bool aux = true;
            while (aux)
            {
                Console.WriteLine("\n+------------------------------------------------------+");
                Console.WriteLine("|               - Ejercicios Clase 5 -                 |");
                Console.WriteLine("| 1. Genericos                                         |");
                Console.WriteLine("| 2. Colecciones                                       |");
                Console.WriteLine("| 0. Salir                                             |");
                Console.WriteLine("+------------------------------------------------------+\n");

                Console.Write("Opcion: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Genericos();
                        break;
                    case "2":
                        Colecciones();
                        break;
                    case "0":
                        aux = false;
                        break;
                }
            }
        }

        private void Genericos()
        {
            bool aux = true;
            while (aux)
            {
                Console.WriteLine("\n+------------------------------------------------------+");
                Console.WriteLine("|                     - Genericos -                    |");
                Console.WriteLine("| 1. Clase generica simple                             |");
                Console.WriteLine("| 2. Instanciación múltiple                            |");
                Console.WriteLine("| 3. Método genérico                                   |");
                Console.WriteLine("| 4. Restricciones                                     |");
                Console.WriteLine("| 5. Uso combinado con colecciones                     |");
                Console.WriteLine("| 6. Integración                                       |");
                Console.WriteLine("| 7. Búsqueda genérica en múltiples clases             |");
                Console.WriteLine("| 0. Salir                                             |");
                Console.WriteLine("+------------------------------------------------------+\n");
                Console.Write("Opcion: ");
                string opcionGenerico = Console.ReadLine();

                switch (opcionGenerico)
                {
                    case "1":
                        Genericos1();
                        break;
                    case "2":
                        Genericos2();
                        break;
                    case "3":
                        Genericos3();
                        break;
                    case "4":
                        Genericos4();
                        break;
                    case "5":
                        Genericos5();
                        break;
                    case "6":
                        Genericos6();
                        break;
                    case "7":
                        Console.WriteLine("Opcion 7");
                        break;
                    case "0":
                        aux = false;
                        break;
                }
            }
        }

        void Genericos1()
        {
            Console.WriteLine();
            Caja<int> caja1 = new Caja<int>(12);
            caja1.MostrarContenido();
        }

        void Genericos2()
        {
            Console.WriteLine();
            Caja<int> caja2 = new Caja<int>(12);
            Caja<string> caja3 = new Caja<string>("Gonzalo");
            Caja<bool> caja4 = new Caja<bool>(true);
            caja2.MostrarContenido();
            caja3.MostrarContenido();
            caja4.MostrarContenido();
        }

        void Genericos3()
        {
            Utilidades utilidades = new Utilidades();
            utilidades.Imprimir(12);
            utilidades.Imprimir("Carlos");
            utilidades.Imprimir(false);
        }
        void Genericos4()
        {
            Repositorio<Caja<int>> repoCaja = new Repositorio<Caja<int>>();
            repoCaja.Agregar(new Caja<int>(12));
            repoCaja.Agregar(new Caja<int>(13));
            repoCaja.Agregar(new Caja<int>(14));
            repoCaja.Agregar(new Caja<int>(15));
            foreach (Caja<int> c in repoCaja.ObtenerTodos())
            {
                c.MostrarContenido();
            }
        }
        void Genericos5()
        {
            Repositorio<Usuario> repoUsuarios = new Repositorio<Usuario>();

            repoUsuarios.Agregar(new Usuario("Matias", "matias@mail.com"));
            repoUsuarios.Agregar(new Usuario("Gonzalo", "gonzalo@mail.com"));
            repoUsuarios.Agregar(new Usuario("Tamara", "tamara@mail.com"));

            foreach (var usuario in repoUsuarios.ObtenerTodos())
            {
                Console.WriteLine(usuario);
            }
        }
        void Genericos6()
        {
            Repositorio<Usuario> repoUsuarios1 = new Repositorio<Usuario>();
            repoUsuarios1.Agregar(new Usuario("Matias", "matias@mail.com"));
            repoUsuarios1.Agregar(new Usuario("Gonzalo", "gonzalo@mail.com"));

            Utilidades utilidadesBuscar = new Utilidades();
            Usuario encontrado = utilidadesBuscar.BuscarPorNombre(repoUsuarios1, "gonzalo");

            if (encontrado != null)
                Console.WriteLine($"Encontrado: {encontrado}");
            else
                Console.WriteLine("No se encontro el usuario");
        }

        private void Colecciones()
        {
            bool aux = true;
            while (aux)
            {
                Console.WriteLine("\n+------------------------------------------------------+");
                Console.WriteLine("|                     - Colecciones -                  |");
                Console.WriteLine("| 1. Agenda de contactos                               |");
                Console.WriteLine("| 2. Contador de visitas web                           |");
                Console.WriteLine("| 3. Gestión de productos                              |");
                Console.WriteLine("| 4. Tareas pendientes con prioridad                   |");
                Console.WriteLine("| 5. Sistema de tickets de soporte                     |");
                Console.WriteLine("| 6. Cola de pacientes en hospital                     |");
                Console.WriteLine("| 7. Operaciones matemáticas                           |");
                Console.WriteLine("| 8. Validación de login                               |");
                Console.WriteLine("| 9. Coordenadas de ubicación                          |");
                Console.WriteLine("| 0. Salir                                             |");
                Console.WriteLine("+------------------------------------------------------+\n");
                Console.Write("Opcion: ");
                string opcionColecciones = Console.ReadLine();

                switch (opcionColecciones)
                {
                    case "1":
                        Colecciones1();

                        break;

                    case "2":
                        Colecciones2();

                        break;
                    case "3":
                        Colecciones3();

                        break;
                    case "4":
                        Colecciones4();

                        break;
                    case "5":
                        Colecciones5();

                        break;
                    case "6":
                        Colecciones6();

                        break;
                    case "7":
                        Colecciones7();

                        break;
                    case "8":
                        Colecciones8();

                        break;
                    case "9":
                        Colecciones9();

                        break;
                    case "0":
                        aux = false;
                        break;
                }
            }
        }

        private void Colecciones1()
        {
            Dictionary<string, string> contactos = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            contactos.Add("Gonzalo", "123456789");
            contactos.Add("Camila", "666666666");
            contactos.Add("Lucas", "555555555");

            Console.Write("Ingrese el nombre a buscar: ");
            string nombre = Console.ReadLine();

            if (contactos.TryGetValue(nombre, out string telefono))
            {
                Console.WriteLine($"El telefono de {nombre} es {telefono}");
            }
            else
            {
                Console.WriteLine("No se encontro ese contacto");
            }
        }
        private void Colecciones2()
        {
            Dictionary<string, int> visitas = new Dictionary<string, int>();

            void RegistrarVisita(string url)
            {
                if (visitas.ContainsKey(url))
                    visitas[url]++;
                else
                    visitas[url] = 1;
            }

            RegistrarVisita("/home");
            RegistrarVisita("/login");
            RegistrarVisita("/carrito");
            RegistrarVisita("/home");
            RegistrarVisita("/carrito");

            Console.WriteLine("Registro de visitas:");
            foreach (var entrada in visitas)
            {
                Console.WriteLine($"{entrada.Key} - {entrada.Value} visitas");
            }
        }
        private void Colecciones3()
        {
            Dictionary<string, string> productos = new Dictionary<string, string>();

            productos.Add("1234", "Auricular");
            productos.Add("5678", "Mouse");
            productos.Add("9101", "Monitor");
            productos.Add("1213", "Webcam");

            Console.Write("Ingrese el codigo del producto: ");
            string codigo = Console.ReadLine();

            if (productos.TryGetValue(codigo, out string nombreProducto))
            {
                Console.WriteLine($"El producto con codigo {codigo} es: {nombreProducto}");
            }
            else
            {
                Console.WriteLine("Producto no encontrado");
            }
        }
        private void Colecciones4()
        {
            PriorityQueue<string, int> tareas = new PriorityQueue<string, int>();

            tareas.Enqueue("Documentar codigo", 2);
            tareas.Enqueue("Responder correos", 3);
            tareas.Enqueue("Daily", 1);
            tareas.Enqueue("Resolver bug", 5);

            Console.WriteLine("Procesando tareas en orden de prioridad:\n");

            while (tareas.Count > 0)
            {
                string tarea = tareas.Dequeue();
                Console.WriteLine($"- {tarea}");
            }
        }
        private void Colecciones5()
        {
            PriorityQueue<string, int> tickets = new PriorityQueue<string, int>();

            tickets.Enqueue("Servidor caido", 1);
            tickets.Enqueue("Error en login de usuario", 2);
            tickets.Enqueue("Error en facturacion", 4);
            tickets.Enqueue("Bug", 5);
            tickets.Enqueue("Problemas de versionado", 3);

            Console.WriteLine("Atendiendo tickets de soporte según prioridad:\n");

            while (tickets.Count > 0)
            {
                string ticket = tickets.Dequeue();
                Console.WriteLine($"- {ticket}");
            }
        }
        private void Colecciones6()
        {
            PriorityQueue<string, int> salaDeEspera = new PriorityQueue<string, int>();

            salaDeEspera.Enqueue("Pepe", 5);
            salaDeEspera.Enqueue("Luis", 2);
            salaDeEspera.Enqueue("Maria", 8);
            salaDeEspera.Enqueue("Gonzalo", 1);
            salaDeEspera.Enqueue("Camila", 4);

            Console.WriteLine("Orden de atencion en la sala de espera:\n");

            while (salaDeEspera.Count > 0)
            {
                string paciente = salaDeEspera.Dequeue();
                Console.WriteLine($"- {paciente}");
            }
        }
        private void Colecciones7()
        {
            (int suma, int resta, int multiplicacion) CalcularOperaciones(int a, int b)
            {
                return (a + b, a - b, a * b);
            }

            Console.Write("Ingrese el primer numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            var resultados = CalcularOperaciones(num1, num2);

            Console.WriteLine($"Suma: {resultados.suma}");
            Console.WriteLine($"Resta: {resultados.resta}");
            Console.WriteLine($"Multiplicacion: {resultados.multiplicacion}");
        }
        private void Colecciones8()
        {
            (bool valido, string mensaje) ValidarAcceso(string usuario, string pass)
            {
                if (usuario == "admin" && pass == "1234")
                {
                    return (true, "Acceso concedido");
                }
                else
                {
                    return (false, "Acceso denegado");
                }
            }
            Console.Write("Ingrese su usuario: ");
            string usuario = Console.ReadLine();

            Console.Write("Ingrese su contraseña: ");
            string pass = Console.ReadLine();

            var resultado = ValidarAcceso(usuario, pass);

            Console.WriteLine($"Resultado: {resultado.mensaje}");
        }
        private void Colecciones9()
        {
            (double Latitud, double Longitud) ObtenerCoordenadas()
            {
                double lat = -36.6012;
                double lon = -60.4026;

                return (lat, lon);
            }
            var coordenadas = ObtenerCoordenadas();

            Console.WriteLine($"Latitud = {coordenadas.Latitud}, Longitud = {coordenadas.Longitud}");
        }
    }
}

