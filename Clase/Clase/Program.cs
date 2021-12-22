using System;

namespace Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un objeto de tipo Rectangulo   
            Rectangulo rect = new Rectangulo();
            rect.Altura = 10;
            rect.Base = 5;

            int area = rect.CalcularArea();
            Console.WriteLine("rect: {0} x {1}, area: {2}", rect.Base, rect.Altura, area);

            //sintaxis de inicializacion
            Rectangulo rect2 = new Rectangulo { Altura = 3, Base = 8 };
            
            int area2 = rect2.CalcularArea();
            Console.WriteLine("rect: {0} x {1}, area: {2}", rect2.Base, rect2.Altura, area2);

        }
    }
}
