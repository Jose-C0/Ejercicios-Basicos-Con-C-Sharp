using System;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta = new CuentaBancaria();

            cuenta.Saldo = -5;
            Console.WriteLine("Saldo despues de primera asignacion: {0}", cuenta.Saldo);

            cuenta.Saldo = 10;
            Console.WriteLine("Saldo despues de segundo asignacion: {0}", cuenta.Saldo);
        }
    }
}
