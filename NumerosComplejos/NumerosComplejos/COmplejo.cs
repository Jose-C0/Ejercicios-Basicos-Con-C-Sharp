using System;
using System.Collections.Generic;
using System.Text;

namespace NumerosComplejos
{
    struct Complejo
    {
        public double Real { get; }
        public double Imaginario{ get; }
        public Complejo( double real, double imaginario) : this()
        {
            Real = real;
            Imaginario = imaginario;
            
        }
        public Complejo Suma(Complejo otro)
        {
            return new Complejo(Real + otro.Real, Imaginario + otro.Imaginario);

        }

        public Complejo MUltiplicacion (Complejo otro)
        {
            return new Complejo(Real * otro.Real - Imaginario * otro.Imaginario,
                Real * otro.Imaginario + Imaginario * otro.Real);

        }

        public override string ToString()
        {
            return String.Format("Re: {0:0.0}, Im: {1:0.0}i", Real, Imaginario);
        }






    }
}
