using System;

namespace ArreglosMultidimensionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //decalarar arreglo con 3 filas y dos columnas
            int[,] a = new int[3, 2] {  { 0, 0 },  { 1, 2 }, { 2, 4 } };

            //Mostrar el arreglo
            for (int i = 0; i < a.GetLength(0); i ++)
            {
                for(int j = 0; j < a.GetLength(1); j ++)
                {
                    Console.WriteLine("a[{0}, {1}] = {2}", i, j, a[i, j]);
                }
            }

            int[,] matriz = new int[3, 3] { { 5, 1, 8},
                                            { 2, 4, 9 },
                                            { 1, 2, 3 }
            };

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0}", matriz[i, j]); 
                }
                Console.WriteLine();
            }
            //decalrar un arreglo de  10 x 8, inicializado en 0
            int[,] arreglo = new int[10, 8];

            Console.Read();
        }
    }
}
