using System;
using System.Collections.Generic;
using System.Text;

namespace OtroNamespace
{
    class MiClase
    {
        //Puede ser visto por cualquier clase
        public void MetodoPublico()
        {
            Console.WriteLine("Llamado  a metodo publico");
        } 
        //Puede ser visto desde esta clase o cualquier clase que herede de MiClase
        protected void MetodoProtected()
        {
            Console.WriteLine("Llamado a metodo protected");
        }

        //Puede ser visto por cualquier clase dentro del mismo Assembly
        internal void MetodoInternal()
        {
            Console.WriteLine("Llamado a metodo internal");
        }

        //Puede ser visto solo por la clase
        private void MetodoPrivate()
        {
            Console.WriteLine("Llamado a metodo privado");
        }


    }
}
