using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 30;
            int b = 11;
            //Operadores aritmeticos
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b); //modulo

            Boolean par = a % 2 == 0;

            //Operadores unarios
            a++; //a = a+1;
            a--; //a= a-1;

            //Operadores de comparacion

            Console.WriteLine(a > b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a < b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

        }
    }
}
