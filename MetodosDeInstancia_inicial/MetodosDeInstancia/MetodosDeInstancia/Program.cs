using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetodosDeInstancia
{
    /// <summary>
    /// Métodos de instancia
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta1 = new CuentaBancaria("001", "Jhon Done", 100);
            CuentaBancaria cuenta2 = new CuentaBancaria("002", "Jane Done", 250);

            //Llamado a los metodos depositar y retirar
            Console.WriteLine("Depositar $70 en cuenta1");
            cuenta1.Depositar(70);


            Console.WriteLine("Depositar $20 en cuenta1");
            cuenta1.Depositar(20);

            //Console.WriteLine("{0}", cuenta1.Saldo);
            Console.WriteLine(cuenta1.ToString());
            Console.WriteLine(cuenta2);









            Console.Read();
        }
    }
}
