using System;

namespace OperacionesMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrizA = { {1.1, 0.3 }, { 5.5, 8 }};
            double[,] matrizB = { { 6, -2.1 }, { 0, 10.5 } };

            Console.WriteLine("Matriz A");
            MostrarMatriz(matrizA);

            Console.WriteLine("Matriz B");
            MostrarMatriz(matrizB);

            double[,] suma = new double[2, 2];
            for (int i = 0; i < suma.GetLength(0); i++)
            {
                for (int j = 0; j < suma.GetLength(1); j++)
                {
                    suma[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            Console.WriteLine("A + B");
            MostrarMatriz(suma);

            static void MostrarMatriz(double[,] matriz)
            {
                for(int i = 0; i < matriz.GetLength(0); i ++)
                {
                    for(int j = 0; j < matriz.GetLength(1); j++)
                    {
                        Console.Write("{0:0.#0} ", matriz[i, j]);
                    }
                    Console.WriteLine();
                }


            }




        }
    }
}
