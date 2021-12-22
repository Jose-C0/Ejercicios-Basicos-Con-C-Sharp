 using System;

namespace ClaseObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Jhon Done", 31);
            Persona p2 = new Persona("Jhon Done", 31);
            Persona p3 = p1;

            //comparacion por referncia
            Console.WriteLine("Referencias p1 y p2 son iguales:");
            Console.Write(p3 == p1);

            Console.WriteLine();
            // comparacion de objetos
            Console.Write("Objetos de p1 y p2 son iguales: ");
            Console.WriteLine(p1.Equals(p2));
            Console.Write("objetos de p2 y p3 son iguales: ");
            Console.WriteLine(p2.Equals(p3));
            Console.Write("Objetos de p1 y p3 son iguales: ");
            Console.WriteLine(p1.Equals(p3));



        }
    }
}
