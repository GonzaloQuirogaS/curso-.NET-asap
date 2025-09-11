using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_4
{
    internal abstract class UsuarioWeb
    {
        string nombre;
        string correo;

        protected UsuarioWeb(string nombre, string correo)
        {
            this.nombre = nombre;
            this.correo = correo;
        }

        public abstract void AccederPanel();
    }
}
