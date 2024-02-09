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
            Arreglo4();
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
            void SustitucionNombres()
            {
                string Nombre = "Carlos Peña";
                string nsust()
                {
                    return Nombre.Replace("Carlos", "Carla");
                }
                Console.WriteLine(nsust());
            }
            void CondicionalMultiple()
            {
                int mes;
                Console.WriteLine("Ingresa el número del mes:");
                mes = int.Parse(Console.ReadLine());

                switch(mes) 
                {
                    case 1:
                        Console.WriteLine("Enero");
                        break;
                    case 2:
                        Console.WriteLine("Febrero");
                        break;
                    case 3:
                        Console.WriteLine("Marzo");
                        break;
                    case 4:
                        Console.WriteLine("Abril");
                        break;
                    case 5:
                        Console.WriteLine("Mayo");
                        break;
                    case 6:
                        Console.WriteLine("Junio");
                        break;
                    case 7:
                        Console.WriteLine("Julio");
                        break;
                    case 8:
                        Console.WriteLine("Agosto");
                        break;
                    case 9:
                        Console.WriteLine("Septiembre");
                        break;
                    case 10:
                        Console.WriteLine("Octubre");
                        break;
                    case 11:
                        Console.WriteLine("Noviembre");
                        break;
                    case 12:
                        Console.WriteLine("Diciembre");
                        break;
                    default:
                        Console.WriteLine("No existe ese mes.");
                        break;
                }

            }
            #region Arreglos
            void Arreglo1()
            {
                double[] n1 = new double[5];

                n1[0] = 5;
                n1[1] = 4;
                n1[2] = 3;
                n1[3] = 2;
                n1[4] = 1;

                for (int i = 0; i < n1.Length; i++)
                {
                    Console.WriteLine(n1[i]);
                }

                //string[] s1 = { "uno", "dos", "tres" };
            }
            void Arreglo2()
            {
                int n = 0;
                string[] ListaMandado = new string[2];
                double[] PrecioArticulos = new double[2];
                int[] Cantidad = new int[2];
                double[] SubTotal = new double[2];

                Console.WriteLine("-- INGRESE LOS ARTICULOS AL CARRITO DE COMPRAS --");
                for (int i = 0; i < ListaMandado.Length; i++)
                {
                    n++;
                    Console.WriteLine($"{n}.");
                    string res = Console.ReadLine();
                    ListaMandado[i] = res;
                    Console.WriteLine("Precio: ");
                    double precio = double.Parse(Console.ReadLine());
                    PrecioArticulos[i] = precio;
                    Console.WriteLine("Cantidad del producto: ");
                    int Cant = int.Parse(Console.ReadLine());
                    Cantidad[i] = Cant;
                    SubTotal[i] = PrecioArticulos[i] * Cantidad[i];
                }
                Console.Clear();
                double Subtotal = 0, Total = 0;
                for(int x = 0; x < 2; x++)
                {
                    Subtotal = SubTotal[x];
                    Total = Total + Subtotal;
                }
                Console.WriteLine(" -- LISTA DE MANDADO --");
                for (int y = 0; y < 2; y++)
                {
                    Console.WriteLine($"{ListaMandado[y]}  -  ${PrecioArticulos[y]}  -  #{Cantidad[y]}  -  Subtotal: ${SubTotal[y]}");
                }
                Console.WriteLine($"                                 Total: ${Total}");
            }
            void Arreglo3()
            {
                int n = 0;
                string[] ListaMandado = new string[2];
                double[] PrecioArticulos = new double[2];
                int[] Cantidad = new int[2];
                string[] SubTotal = new string[2];

                Console.WriteLine("-- INGRESE LOS ARTICULOS AL CARRITO DE COMPRAS --");
                for (int i = 0; i < ListaMandado.Length; i++)
                {
                    n++;
                    Console.WriteLine($"{n}.");
                    string res = Console.ReadLine();
                    ListaMandado[i] = res;
                    Console.WriteLine("Precio: ");
                    double precio = double.Parse(Console.ReadLine());
                    PrecioArticulos[i] = precio;
                }
                Console.Clear();
                
                //Console.WriteLine(" -- LISTA DE MANDADO --");
                for (int y = 0; y < 2; y++)
                {
                    Console.WriteLine($"{ListaMandado[y]}  -  ${PrecioArticulos[y]}");
                    Console.WriteLine("¿Cuantos articulos desea agregar?");
                    int Cant = int.Parse(Console.ReadLine());
                    Cantidad[y] = Cant;
                    SubTotal[y] = (PrecioArticulos[y] * Cantidad[y]).ToString();
                }
                double Subtotal = 0, Total = 0;
                for (int x = 0; x < 2; x++)
                {
                    Subtotal = Convert.ToDouble(SubTotal[x]);
                    Total = Total + Subtotal;
                }
                Console.Clear();
                for (int y = 0; y < 2; y++)
                {
                    Console.WriteLine($"{ListaMandado[y]}  -  #{Cantidad[y]}  -  ${SubTotal[y]}");
                }
                Console.WriteLine($"                     Total: ${Total}");
            }
            void Arreglo4()
            {
                double[] n1 = new double[5];

                n1[0] = 5;
                n1[1] = 4;
                n1[2] = 3;
                n1[3] = 2;
                n1[4] = 1;

                double Sumatoria = 0;
                for (int i = 0; i < n1.Length; i++)
                {
                    Console.WriteLine($"{Sumatoria} = {Sumatoria} + {n1[i]}");
                    Sumatoria = Sumatoria + n1[i];
                    Console.WriteLine(Sumatoria);
                }
            }
            #endregion
            Console.ReadLine();
        }

    }
}
