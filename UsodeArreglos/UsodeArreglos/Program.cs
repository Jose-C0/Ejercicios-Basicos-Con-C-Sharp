using System;
using System.Text;

namespace UsodeArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Tamaño del arreglo?");
            //int tam = Convert.ToInt32(Console.ReadLine());

            ////DEFINIR EL ARREGOL
            //int[] numeros = new int[tam];

            ////leer datos y guardarlos en el arreglo
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.Write("Escribe numero en indice {0}: ", i);
            //    numeros[i] = Convert.ToInt32(Console.ReadLine());
            //}

            ////Muestra los datos
            //Console.WriteLine("Los datos que ingresaste son: ");
            //MostrarArreglo(numeros);
    

            int[] datos = { -1, -2, 20, 19, 18, 15, 5 };
            int i, j, datoTemporal;
            int n = 7; // Numero de datos 

            int[] datos3 = { -1, -2, 20, 19, 18, 15, 5 };
            for (i = 1; i < n; i++)
            {
                foreach (int dato in datos3) // Muestro datos
                    Console.Write("{0} ", dato);
                Console.WriteLine();

                j = i - 1;
                while ((j >= 0) && (datos3[j] > datos3[j + 1]))
                {
                    datoTemporal = datos3[j];
                    datos3[j] = datos3[j + 1];
                    datos3[j + 1] = datoTemporal;
                    j--;
                }
            }
            Console.Write("Ordenado:");

            foreach (int dato in datos3) // Muestro datos finales
                Console.Write("{0} ", dato);
            Console.WriteLine();
        }


        static void MostrarArreglo(int[] arreglo)
        {

            foreach (int num in arreglo)
            {
                Console.Write("{0}", num);
            }
            Console.WriteLine();
        }
    }

}
