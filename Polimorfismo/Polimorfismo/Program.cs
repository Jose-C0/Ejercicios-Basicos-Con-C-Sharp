using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Upcasting
            IFiguras f1 = new Circulo { Radio = 5 };
            IFiguras f2 = new Triangulo { Base = 10, Altura = 8 };
            IFiguras f3 = new Rectangulo { Base = 4, Altura = 3 };
            IFiguras f4 = new Circulo { Radio = 9 };

            IFiguras[] figuras = new IFiguras[] { f1, f2, f3, f4 };

            foreach (var figura in figuras)
            {
                Console.WriteLine(figura.CalcularArea());
            }

            //Downcasting
            Circulo c = f1 as Circulo;
            Console.WriteLine("Datos del circulo");
            c.DatosCirculos();



        }
    }
}
