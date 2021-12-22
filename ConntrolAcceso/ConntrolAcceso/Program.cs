using System;
using OtroNamespace;

namespace ConntrolAcceso
{
    class Program
    {
        static void Main(string[] args)
        {


            MiClase obj = new MiClase();
            obj.MetodoPublico();
            obj.MetodoInternal();
           // obj.MetodoProtected();
            //obj.MetodoPrivado();


        }
    }
}
