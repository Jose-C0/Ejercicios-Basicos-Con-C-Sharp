using System;

namespace ClaseAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpleadoHonorarios eh = new EmpleadoHonorarios("Jhon", "Ventas", 12000);
            eh.Trabajar();
            Console.WriteLine("Salario por honorarios: {0}", eh.Salario);

            EmpleadoNomina en = new EmpleadoNomina("Jane", "RH", 9000);
            en.Trabajar();
            Console.WriteLine("Salario por nomina: {0}", eh.Salario);


        }
    }
}
