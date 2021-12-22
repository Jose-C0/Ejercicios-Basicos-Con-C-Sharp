using System;

namespace Ciclos2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break; //terminar con el ciclo
                }
                Console.WriteLine("Valores del contador i: {0}", i);
            }

            Console.WriteLine("Uso de continue");
            int n = 0;
            while (n < 10)
            {
                if (n % 2 == 0)
                {
                    n++;
                    continue;
                }

                Console.WriteLine("Valores del contador n: {0}", n);
                n ++;

            }



        }
    }
}
