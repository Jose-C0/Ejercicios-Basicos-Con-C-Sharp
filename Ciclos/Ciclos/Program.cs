using System;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
        //Ciclo for
        Console.WriteLine("Usando ciclo for");
        for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valores del contador i: {0}", i);
            }

         //Ciclo while
         Console.WriteLine("\nUsando ciclo while");
         int n = 0; //declaracion del contador
        while (n < 5)
            {
                Console.WriteLine("Valor del contador n: {0}", n);
                n++;
            }

            //Ciclo Do - while
            Console.WriteLine("\nUsando ciclo Do - while");
            int c = 0;
            do
            {
                Console.WriteLine("Valor del contador c: {0}", c);
                c++;
            } while (c < 5);


        }
    }
}
