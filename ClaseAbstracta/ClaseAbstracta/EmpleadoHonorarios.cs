using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseAbstracta
{
    class EmpleadoHonorarios : Empleado
    {

        public decimal SueldoBase { get; set; }

        public override decimal Salario 
        { 
            get
            {
                return SueldoBase * 0.84m;
            }
        }
        
        public EmpleadoHonorarios(String nombre, string puesto, decimal sueldoBase) 
            : base(nombre, puesto)
        {
            SueldoBase = sueldoBase;
        }

        public override void Trabajar()
        {
            Console.WriteLine("Trabajando por honorarios");
        }


    }
}
