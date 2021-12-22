﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiembrosEstaticos
{
    /// <summary>
    /// Miembros estáticos
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta1 = new CuentaBancaria("001", "John Doe", 100);
            CuentaBancaria cuenta2 = new CuentaBancaria("002", "Jane Doe", 250);

            CuentaBancaria.Banco = "Mi Banco";

            Console.WriteLine(cuenta1);
            Console.WriteLine(cuenta2);

            Console.WriteLine("Cambiando el banco...");
            CuentaBancaria.AsignarBanco("Otro Banco");

            Console.WriteLine(cuenta1);
            Console.WriteLine(cuenta2);


            Console.Read();



        }
    }
}
