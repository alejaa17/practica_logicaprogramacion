﻿using System;

namespace Matriz_NXN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filas = 0;
            int columnas = 0;
            Console.WriteLine("Bienvenido a matriz de N X  N.");
            Console.WriteLine("Ingrese las filas de la matriz:");
            filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las columnas de la matriz:");
            columnas = int.Parse(Console.ReadLine());
            int[,] array1 = new int[filas, columnas];
            Random rnd = new Random();


            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
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
