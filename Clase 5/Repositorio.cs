using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_5
{
    internal class Repositorio<T> where T : class
    {
        private List<T> items = new List<T>();
        public void Agregar(T item)
        {
            items.Add(item);
        }

        public List<T> ObtenerTodos()
        {
            return items;
        }
    }
}
