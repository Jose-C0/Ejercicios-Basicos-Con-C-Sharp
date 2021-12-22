using System;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //usando constructor con 1 argumento
            CuentaBancaria cuenta1 = new CuentaBancaria("001");
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", cuenta1.NoCuenta,
                                                                         cuenta1.Usuario,
                                                                         cuenta1.Saldo
                                                                         );

            //usando constructor con 2 argumento
            CuentaBancaria cuenta2 = new CuentaBancaria("002", "jose");
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", cuenta2.NoCuenta,
                                                                         cuenta2.Usuario,
                                                                         cuenta2.Saldo
                                                                         );
            //usando constructor con 3 argumento
            CuentaBancaria cuenta3 = new CuentaBancaria("003", "Juna", 100 );
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", cuenta3.NoCuenta,
                                                                         cuenta3.Usuario,
                                                                         cuenta3.Saldo
                                                                         );


        }
    }
}
