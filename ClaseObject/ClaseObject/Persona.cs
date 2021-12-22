using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseObject
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad) 
        {

            Nombre = nombre;
            Edad = edad;


        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Persona p = obj as Persona;
            if (p == null)
            {
                return false;
            }
            return (Nombre == p.Nombre) && (Edad == p.Edad);

        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = (hash * 7) + Nombre.GetHashCode();
            hash = (hash * 7) + Edad.GetHashCode();

            return hash;

        }

    }
}

