namespace Ejercicios.Clase_3
{
    internal class Ejercicio14
    {
        Queue<string> documentos = new Queue<string>();

        public void impresora()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nPor favor ingrese una opcion: ");
                Console.WriteLine("1. Agregar documentos a la cola de impresion");
                Console.WriteLine("2. Ver cola");
                Console.WriteLine("3. Procesar documento");
                Console.WriteLine("4. Salir");

                Console.Write("Opcion: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("\nIngrese un documentos: ");
                        string documento = Console.ReadLine();
                        documentos.Enqueue(documento);
                        Console.WriteLine("Documentos agregado a la cola.");
                        break;

                    case "2":
                        if (documentos.Count > 0)
                        {
                            Console.WriteLine("\nLos documentos en cola son:");
                            foreach (string doc in documentos)
                            {
                                Console.WriteLine("- " + doc);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nLa cola esta vacia.");
                        }
                        break;

                    case "3":
                        if (documentos.Count > 0)
                        {
                            Console.WriteLine("Documento: " + documentos.Dequeue() + " procesado");
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
