using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_5
{
    internal class Utilidades
    {
        public void Imprimir<T>(T valor)
        {
            Console.WriteLine($"Valor: {valor}");
        }

        public T BuscarPorNombre<T>(Repositorio<T> repo, string nombre) where T : class
        {
            var resultado = repo.ObtenerTodos().FirstOrDefault(item => item != null && item.ToString().Contains(nombre));
            if (resultado != null)
            {
                return resultado;
            }
            else
            {
                return null;
            }
        }
    }
}
