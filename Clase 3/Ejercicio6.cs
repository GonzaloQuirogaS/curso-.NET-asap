using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_3
{
    internal class Ejercicio6
    {
        List<List<string>> baseDeDatosClientes = new List<List<string>>();

        private void agregarClientes()
        {
            baseDeDatosClientes.Add(new List<string> { "Pepe Argento", "45", "Zapatero", "pepe@gmail.com" });
            baseDeDatosClientes.Add(new List<string> { "Mike Tyson", "60", "Boxeador", "tyson@gmail.com" });
            baseDeDatosClientes.Add(new List<string> { "Marta López", "27", "Diseñadora UX", "marta@gmail.com" });
            baseDeDatosClientes.Add(new List<string> { "Daddy Yankee", "50", "Cantante", "yankee@gmail.com" });
            baseDeDatosClientes.Add(new List<string> { "Rene Favaloro", "90", "Medico", "rene@gmail.com" });
        }

        public void mostrarBaseDeDatos()
        {
            agregarClientes();
            Console.WriteLine("Lista de clientes: ");
            for (int i = 0; i < baseDeDatosClientes.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + string.Join(" - ", baseDeDatosClientes[i]));
            }
        }
    }
}
