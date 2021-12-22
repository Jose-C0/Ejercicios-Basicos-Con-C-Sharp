using System;

namespace Sentencias_Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //if
            int num = 10;

            if (num > 5)
            {
                Console.WriteLine("numero es mayor que : 5");
            }

            //Condicional Compuesta
            string user = "user1";
            string pass = "hola123";

            if (user == "user1" && pass == "hola123")
            {
                Console.WriteLine("Acceso Correcto");
            }

            //IF - ELSE
            int edad = 23;

            if (edad >= 18)
            {
                Console.WriteLine("Mayor de edad");
            }
            else
            {
                Console.WriteLine("Menor de edad");
            }

            //if - else if

            int a = 6;
            int b = 8;

            if (a > b)
            {
                Console.WriteLine("{0} > {1}", a, b);
            }
            else if (a < b)
            {
                Console.WriteLine("{0} < {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} == {1}", a, b);

            }

            //switch
            string codigo = "A1";
            switch (codigo)
            {
                case "A1":
                    Console.WriteLine("Producto 1");
                    break;

                case "A2":
                    Console.WriteLine("Producto 2");
                    break;

                case "A3":
                    Console.WriteLine("Producto 3");
                    break;
                default:
                    Console.WriteLine("Producto no encontrado");
                    break;

            }




        }
    }
}
