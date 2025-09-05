namespace Ejercicios.Clase_3
{
    internal class Ejercicio13
    {
        Queue<string> usuarios = new Queue<string>();

        public void cola()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nPor favor ingrese una opcion: ");
                Console.WriteLine("1. Agregar usuario a la cola");
                Console.WriteLine("2. Ver cola");
                Console.WriteLine("3. Salir");
                Console.Write("Opcion: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("\nIngrese un usuario: ");
                        string usuario = Console.ReadLine();
                        usuarios.Enqueue(usuario);
                        Console.WriteLine("Usuario agregado a la cola.");
                        break;

                    case "2":
                        if (usuarios.Count > 0)
                        {
                            Console.WriteLine("\nLos usuarios en la cola son:");
                            foreach (string u in usuarios)
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
                        Console.WriteLine("Saliendo del programa.");
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción no valida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}
