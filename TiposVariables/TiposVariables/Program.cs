using System;

namespace TiposVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos enteros
            //System.Int32
            int entero = 100; //32 bits
            //System.Int16
            short s = 140; //16 bits
            //System.Byte
            byte b = 10; //8 bits
            //System.Int64
            long largo = 1234568794;//64 bits

            Console.WriteLine("int: {0}, short: {1}", entero, s);

            //Tipos flotante
            //System.Single
            float f = 123.5f;
            //System.Double
            double d = 3.2323;
            //System.Decimal ulizado para operaciones financieras
            decimal dec = 129.99m;

            Console.WriteLine("float: {0}, decimal {1}", f, d);

            //otros
            //System.Char
            char c = 'E';
            //System.Boolean representa un valor verdadero o falso
            bool booleano = true;

            Console.WriteLine("char: {0}", c);
            Console.WriteLine("bool: {0}", booleano);




        }
    }
}
