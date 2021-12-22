using System;

namespace FormatoCadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            int naranjas = 8;
            int platanos = 2;
            int manzanas = 6;
            string resultados = string.Format("Hay {0} platanos, {1} naranja y manzanas", 
                platanos, naranjas, manzanas);
            Console.WriteLine("Pi: {0:0.00}", Math.PI);

            //Ajustar dato con 10 caracteres de espacio
            Console.WriteLine(">{0,10}<", 5);
            //Ajustar dato con 10 caracteres de espacio a la izquierda
            Console.WriteLine("{0,-10}",5);

            //Distintos formatos
            int dato = 126;
            Console.WriteLine("Numero: {0:N}", dato);
            Console.WriteLine("Cientifico: {0:E}", dato);
            Console.WriteLine("Moneda: {0:C}", dato);
            Console.WriteLine("Porcentaje: {0:P}", dato);
            Console.WriteLine("Hexadecimal: {0:X}", dato);


        }
    }
}
