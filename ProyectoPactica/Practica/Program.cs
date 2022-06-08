using System;

namespace Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int opcion = 0;
            Console.WriteLine("Bienvenido a Matriz, usted definirá el tamaño del arreglo: ");

            Console.WriteLine("Ingrese el número de filas y columnas: ");
            n = int.Parse(Console.ReadLine());


            int[,] array1 = new int[n, n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    array1[i, j] = rnd.Next(10);

                    Console.Write(array1[i, j]);
                    Console.Write("|");
 
                }
                Console.WriteLine();

            }

            Console.WriteLine("Fin de la impresión.");

            do
            {
                Console.WriteLine("\n\nIngresa el número según la opción: " + 
                    "\n1. para sumar las filas." +
                    "\n2. para sumar las columnas. " +
                    "\n3. para sumar matriz en X" +
                    "\n0. para salir. ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion){
                    case 1: Console.WriteLine("Suma de filas: ");
                        SumarFilas(array1,n);
                        break;
                        
                    case 2:
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("\nSuma de columnas: " + SumarColumnas(array1, n));
                        Console.WriteLine("----------------------------");
                        break;
                    case 3:
                        Console.WriteLine("\nSuma matriz en X: " + SumarEnX(array1, n));
                        break;

                    case 0: Console.WriteLine("Fin.");
                        break;
                    default: Console.WriteLine("Ingrese una opción válida: ");
                        break;
                }
            } while (opcion != 0);
        }

        public static void SumarFilas(int[,] array1, int n)
        {
            int sf = 0;
            int sft = 0;
            for(int c=0; c < n; c++)
            {
                for(int f = 0; f < n; f++)
                {
                    sf += array1[c, f];
                }

                sft += sf;
                Console.WriteLine("- " + sft);
                sf = 0;
                sft = 0;
            }
        }

        public static int SumarColumnas(int[,] array1, int n)
        {
            int sumaTotalColumnas = 0;
            int sumaPorColumna = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sumaPorColumna += array1[j, i];

                }
                sumaTotalColumnas += sumaPorColumna;    
                Console.Write("|" + sumaPorColumna);
                sumaPorColumna = 0;
                sumaTotalColumnas += sumaPorColumna;
            }
            return sumaTotalColumnas;
        }
        public static int SumarEnX(int[,] array1, int n) {
            int sumaPrimeraDiagonal = 0;
            int sumaSegundaDiagonal = 0;
            int sumaEnX = 0;
            int aux = 0;
            //for primera diagonal
            for (int i = 0; i < n; i++) {

                sumaPrimeraDiagonal += array1[i, i];
            
            
            }
            Console.WriteLine("Suma Primera diagonal:" + sumaPrimeraDiagonal );

            aux = n - 1;
           
            for(int i = 0; i < n; i++) {


                sumaSegundaDiagonal += array1[i, aux];
                aux--;
            
            }
            Console.WriteLine("Suma segunda diagonal:" + sumaSegundaDiagonal);
            sumaEnX = sumaPrimeraDiagonal + sumaSegundaDiagonal;

            return sumaEnX;
        }
    }
}
