using System;
using System.Collections.Generic;
using System.Text;

namespace Clase
{
    class Rectangulo
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public int CalcularArea()
        {
            return Base * Altura;
        }
    }
}
