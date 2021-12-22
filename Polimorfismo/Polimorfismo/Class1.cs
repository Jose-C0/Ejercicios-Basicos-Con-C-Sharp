using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Rectangulo : IFiguras
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public double CalcularArea()
        {
            return Base * Altura;
        }

        public void DatosRectangulo()
        {
            Console.WriteLine("Base: {0}, Altura: {1}", Base, Altura);
        }
    }
}
