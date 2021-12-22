using System;

namespace NumerosAleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int mes = rnd.Next(1, 13); //Crea un numero entre 1 y 13
            int dado = rnd.Next(1, 7); //Crea un numero entre 1 y 6
            double probabilidad = rnd.NextDouble();

            //Llenar un arreglo con numero aleatorio
            int[] arreglo = new int[5];

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = rnd.Next(0, 10);
            }

            foreach (var num in arreglo)
            {
                Console.WriteLine(num);
            }




        }
    }
}
