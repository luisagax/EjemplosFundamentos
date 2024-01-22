using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PFundamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora();
            void Ejemplo1()
            {
                int n1 = 5;
                int n2 = 6;
                int Resultado = 0;

                int Suma(int a, int b)
                {
                    return a + b;
                }

                Resultado = Suma(n1, n2);
            }
            void Calculadora()
            {
                decimal n1 = 0, n2 = 0, resultado = 0;
                Console.WriteLine("<< CALCULADORA BÁSICA >>");
                Console.WriteLine("Ingresa el #1: ");
                n1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Ingresa el #2: ");
                n2 = decimal.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Suma: {0} + {1} = {2}", n1, n2, Suma());
                Console.WriteLine($"Suma: {n1} + {n2} = {Suma()}"); //<-- Solo funciona con la nueva versión de c#
                Console.WriteLine("Resta: {0} - {1} = {2}", n1, n2, Resta());
                Console.WriteLine("Multiplicación: " + n1 + " * " + n2 + " = " + Multiplicacion());
                Console.WriteLine("División: {0} / {1} = {2}", n1, n2, Division());

                decimal Suma()
                {
                    resultado = n1 + n2;
                    return resultado;
                }
                decimal Resta()
                {
                    resultado = n1 - n2;
                    return resultado;
                }
                decimal Multiplicacion()
                {
                    return n1 * n2;
                }
                decimal Division()
                {
                    return n1 / n2;
                }
            }

            Console.ReadLine();
        }
    }
}
