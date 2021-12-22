using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Estudiante : Persona
    {
        public double Promedio { get; set; }
        public string Grado { get; set; }

        public Estudiante() { }
        public Estudiante(string nombre, int edad, double promedio, string grado) : base(nombre, edad)
        {
            Promedio = promedio;
            Grado = grado;
        }
        public  void Estudiar()
        {
            Console.WriteLine("Estudiar");
        }

        public void IrAClase()
        {
            Console.WriteLine("IrAClase");
        }

        public override void Saludar()
        {
            base.Saludar(); //Version de persona
            Console.WriteLine("MI nombre es {0} y mi promedio es {1:0.0} ", Nombre, Promedio);
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0}, Edad: {1}, Promedio: {2}, Grado: {2}",
                Nombre, Edad, Promedio, Grado);
        }
    }
}
