using System;

namespace NumerosComplejos
{
    class Program
    {
        static void Main(string[] args)
        {
            Complejo c1 = new Complejo (3, 4);
            Complejo c2 = new Complejo(-0.5, 2);

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Complejo resultado = c1.Suma(c2);
            Console.WriteLine(resultado);




        }
    }
}
