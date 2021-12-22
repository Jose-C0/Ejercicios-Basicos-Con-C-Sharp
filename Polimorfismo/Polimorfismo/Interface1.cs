using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Circulo : IFiguras
    {
        public int Radio { get; set; }

        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        public void DatosCirculos()
        {
            Console.WriteLine("Radio: {0}", Radio);
        }
    }
}
