using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_2
{
    internal class Ejercicio7
    {
        /*
        static void Main()
        {

            int opcion;

            do
            {
                Console.WriteLine("\n+----- Bienvenido a la calculadora cientifica -----+");
                Console.WriteLine("|         Ingrese la operacion a realizar          |");
                Console.WriteLine("| 1. Suma                                          |");
                Console.WriteLine("| 2. Resta                                         |");
                Console.WriteLine("| 3. Multiplicacion                                |");
                Console.WriteLine("| 4. Division                                      |");
                Console.WriteLine("| 5. Potencia                                      |");
                Console.WriteLine("| 6. Raiz                                          |");
                Console.WriteLine("| 7. Salir                                         |");
                Console.WriteLine("+--------------------------------------------------+");

                Console.Write("Ingrese la operacion a realizar: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\n-------- Ingreso a operacion suma --------");
                        Console.Write("Ingrese el primer numero: ");
                        int num1Suma = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero: ");
                        int num2Suma = int.Parse(Console.ReadLine());
                        double sumaFinal = suma(num1Suma, num2Suma);
                        Console.WriteLine("\nEl resultado de la suma es: " + sumaFinal + "\n");
                        break;

                    case 2:
                        Console.WriteLine("\n-------- Ingreso a operacion resta --------");
                        Console.Write("Ingrese el primer numero: ");
                        int num1Resta = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero: ");
                        int num2Resta = int.Parse(Console.ReadLine());
                        double restaTotal = resta(num1Resta, num2Resta);
                        Console.WriteLine("\nEl resultado de la resta es: " + restaTotal + "\n");
                        break;

                    case 3:
                        Console.WriteLine("\n-------- Ingreso a operacion multiplicacion --------");
                        Console.Write("Ingrese el primer numero: ");
                        int num1Mult = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero: ");
                        int num2Mult = int.Parse(Console.ReadLine());
                        double multTotal = multiplicar(num1Mult, num2Mult);
                        Console.WriteLine("\nEl resultado de la multiplicacion es: " + multTotal + "\n");
                        break;

                    case 4:
                        Console.WriteLine("\n-------- Ingreso a operacion division --------");
                        Console.Write("Ingrese el primer numero: ");
                        int num1Div = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero: ");
                        int num2Div = int.Parse(Console.ReadLine());
                        if (num2Div <= 0)
                        {
                            Console.WriteLine("\nError, el divisor no puede ser 0");
                            break;
                        }
                        double divTotal = dividir(num1Div, num2Div);
                        Console.WriteLine("\nEl resultado de la division es: " + divTotal + "\n");
                        break;

                    case 5:
                        Console.WriteLine("\n-------- Ingreso a operacion potencia --------");
                        Console.Write("Ingrese el numero: ");
                        int num = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese su exponente: ");
                        int exponente = int.Parse(Console.ReadLine());
                        double potenciaTotal = potencia(num, exponente);
                        Console.WriteLine("\nEl resultado de " + num + " a la " + exponente + " es: " + potenciaTotal + "\n");
                        break;

                    case 6:
                        Console.WriteLine("\n-------- Ingreso a operacion raiz --------");
                        Console.Write("Ingrese el numero: ");
                        int numRaiz = int.Parse(Console.ReadLine());
                        double raizTotal = raiz(numRaiz);
                        Console.WriteLine("\nEl resultado de la raiz de " + numRaiz + " es: " + raizTotal + "\n");
                        break;
                }
            }
            while (opcion < 7);

        }

        static double suma(int num1, int num2)
        {
            return num1 + num2;
        }

        static double resta(int num1, int num2)
        {
            return num1 - num2;
        }

        static double multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        static double dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        static double potencia(int num1, int num2)
        {
            return Math.Pow(num1, num2);
        }

        static double raiz(int num)
        {
            return Math.Sqrt(num);
        }
        */
    }
}
