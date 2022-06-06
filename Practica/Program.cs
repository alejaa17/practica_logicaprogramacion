using System;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.WriteLine("Bienvenido a Matriz, usted definirá el tamaño del arreglo: ");

            Console.WriteLine("Ingrese el número de filas y columnas: ");
            n = int.Parse(Console.ReadLine());

            int[,] array1 = new int[n, n];
            Random rnd = new Random();


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Contenido de la fila: "+ i);
                for (int j = 0; j < n; j++)
                {

                    array1[i, j] = rnd.Next(10);

                    Console.Write(array1[i, j]);

                    Console.Write("|");


                }
                Console.WriteLine(" ");

            }

            Console.WriteLine("Fin");
        }
    }
}
