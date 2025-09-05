namespace Ejercicios.Clase_3
{
    internal class Ejercicio15
    {
        Queue<string> turnos = new Queue<string>();

        public void turnero()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nPor favor ingrese una opcion: ");
                Console.WriteLine("1. Agregar usuario");
                Console.WriteLine("2. Ver cola");
                Console.WriteLine("3. Atender usuario");
                Console.WriteLine("4. Salir");

                Console.Write("Opcion: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("\nIngrese un usuario: ");
                        string usuario = Console.ReadLine();
                        turnos.Enqueue(usuario);
                        Console.WriteLine("Usuario agregado a la cola.");
                        break;

                    case "2":
                        if (turnos.Count > 0)
                        {
                            Console.WriteLine("\nLos usuarios en cola son:");
                            foreach (string u in turnos)
                            {
                                Console.WriteLine("- " + u);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nLa cola esta vacia.");
                        }
                        break;

                    case "3":
                        if (turnos.Count > 0)
                        {
                            Console.WriteLine("Usuario: " + turnos.Dequeue() + " atendido");
                        }
                        else
                        {
                            Console.WriteLine("\nLa cola esta vacia.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Saliendo.");
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opcion no valida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}