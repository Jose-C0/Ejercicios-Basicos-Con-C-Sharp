using System;


namespace ClaseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = new int[list.Length];

            //Genera una copia del arreglo lst
            Array.Copy(list, temp, list.Length);

            Console.Write("Arreglo Original: ");
            MostrarArreglo(list);
            Console.Write("Arreglo COPIA: ");
            MostrarArreglo(temp);

            //Invierte el arreglo
            Array.Reverse(temp);
            Console.Write("Arreglo invertido");
            MostrarArreglo(temp);
            
            //Ordenar el arreglo
            Array.Reverse(list);
            Console.Write("Arreglo ordenado");
            MostrarArreglo(list);

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
