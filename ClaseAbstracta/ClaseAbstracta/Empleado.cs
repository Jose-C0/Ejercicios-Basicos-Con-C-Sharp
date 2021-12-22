using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseAbstracta
{
    abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public abstract decimal Salario { get; }

        public Empleado(string nombre, string puesto)
        {
            Nombre = nombre;
            Puesto = puesto;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola mi  nombre es: {0}");
        }

        public abstract void Trabajar();
       


    }
}
