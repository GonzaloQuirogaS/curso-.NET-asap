using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_3
{
    internal class Ejercicio3
    {
        private int[] tiemposCarga = { 120, 150, 90, 200, 180, 110, 95, 170, 160, 130, 140, 100 };

        private double calcularPromedio()
        {
            return tiemposCarga.Average();
        }

        private int menorTiempo()
        {
            return tiemposCarga.Count(tiempo => tiempo > calcularPromedio());
        }

        public void mostrarResultados()
        {
            Console.WriteLine("El promedio de tiempos de carga es: " + calcularPromedio());
            Console.WriteLine("La cantidad de paginas que superan el promedio son: " + menorTiempo());
        }
    }
}
