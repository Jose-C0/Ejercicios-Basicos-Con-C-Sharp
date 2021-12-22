using System;

namespace TiposReferenciasVsTiposValores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos de valor
            Console.WriteLine("TIpos de valor");
            PuntoVal puntoV = new PuntoVal(5, 10);
            PuntoVal otroPunto = puntoV;

            otroPunto.X = 100;
            otroPunto.Y = 60;
            Console.WriteLine("punto: ({0}, {1})", puntoV.X, puntoV.Y);
            Console.WriteLine("otroPunto: ({0}, {1})", otroPunto.X, otroPunto.Y);

            //Tipos de referencia
            Console.WriteLine("Tipos de referncia");
            PuntosRef puntoR = new PuntosRef(5, 10);
            PuntosRef segundoPunto = puntoR;

            segundoPunto.X = 200;
            segundoPunto.Y = 300;
            Console.WriteLine("punto: ({0}, {1}", puntoR.X, puntoR.Y);
            Console.WriteLine("segundoPunto: ({0}, {1})", segundoPunto.X, segundoPunto.Y);



        }
    }
}
