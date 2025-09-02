using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_3
{
    internal class Ejercicio5
    {
        private List<string> comentarios = new List<string> {
            "Buen blog, muy recomendable",
            "No cumplió con mis expectativas",
            "Malo",
            " ",
            "Me gusto",
            "Basura de blog",
            "Que asco",
            "https://www.facebook.com/perfilSpam",
            "www.spam-page.com"
        };

        private List<string> prohibidos = new List<string> { "asco", "basura", "www" };

        private List<string> filtrados = new List<string>();

        private void filtrarComentarios()
        {
            for (int i = 0; i < comentarios.Count; i++)
            {
                string comentario = comentarios[i].Trim();

                if (comentario == "" || comentario.Length < 5)
                {
                    continue;
                }

                bool tieneProhibido = false;
                for (int j = 0; j < prohibidos.Count; j++)
                {
                    string prohibido = prohibidos[j].ToLower();
                    if (comentario.ToLower().Contains(prohibido))
                    {
                        tieneProhibido = true;
                        break;
                    }
                }

                if (!tieneProhibido)
                {
                    filtrados.Add(comentario);
                }
            }
        }

        public void mostrarComentarios()
        {
            filtrarComentarios();
            Console.WriteLine("Comentarios filtrados:");
            for (int i = 0; i < filtrados.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + filtrados[i]);

            }
        }
    }
}
