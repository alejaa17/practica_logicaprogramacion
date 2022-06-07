/*
 *                  C# Básico
 * Crear una aplicacion  de consola en .net core,
 * la aplicacion va a pedir un número, al ser ingresado 
 * va a crear una matriz n x n y van a llenar cada posición
 * de un número aleatorio del 0 al 9, luego van a imprimir
 * la matriz con la misma estructura (filas y columnas)
 * Realizar un menu, que el sitema se mantenga 
 * ejecutando mientras no se presione el número 0 
 * El menu tendrá las siguientes opciones
 * 1. Suma de filas
 * 2. Suma de columnas
 * el menu se debe hacer con un switch y finalmente
 * crear dos métodos que se llamen SumarFilas y SumarColumnas
 * que por ahora no hagan nada
*/
using System;

namespace Capacitacion
{
    internal class Program
    {

        public void SumarFilas()
        {

        }

        public void SumarColumnas()
        {

        }
        static void Main(string[] args)
        {
            int[,] matriz;
            Random rand = new Random();
            int num, numAleatorio, paso, opcion, suma;

            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());

            matriz = new int[num, num];
            Console.WriteLine($"La matriz generada de tamaño {num}, {num} es:\n");
            for (int i = 0; i < matriz.GetLength(0); i++) // Ciclo para las columnas
            {
                for (int j = 0; j < matriz.GetLength(0); j++) // Ciclo para las filas
                {
                    numAleatorio = rand.Next(0, 9); // Genera número aleatorio de 0 a 9
                    matriz[i, j] = numAleatorio; // Llena la matriz con el número aleatorio
                    Console.Write($"| {matriz[i, j]} |"); // Imprime la matriz
                }
                Console.WriteLine();
            }

            do
            {
                Console.WriteLine("\nIngrese una de las siguientes opciones");
                Console.WriteLine("1. Sumar las filas de la matriz\n2. Sumar las columnas de la matriz\nPresione 0 para salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        suma = 0;
                        Console.WriteLine("Ingresó a la opción 1");
                        for (int i = 0; i < matriz.GetLength(0); i++)
                        {
                            for (int j = 0; j < matriz.GetLength(0); j++)
                            {
                                suma += matriz[i, j];

                            }
                        }
                        Console.WriteLine($"\nLa suma de las filas es: {suma}");
                        //opcion = 0;
                        break;

                    case 2:
                        suma = 0;
                        Console.WriteLine("Ingresó a la opción 2");
                        for (int i = 0; i < matriz.GetLength(0); i++)
                        {
                            for (int j = 0; j < matriz.GetLength(0); j++)
                            {
                                suma += matriz[i, j];
                            }
                        }
                        Console.WriteLine($"\nLa suma de las columnas es: {suma}");
                        //opcion = 0;
                        break;

                    default:
                        if (opcion == 0)
                        {
                            Console.WriteLine("Hasta pronto");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese una opción válida\n");
                        }
                        break;
                }
            } while (opcion != 0);

        }
    }
}

