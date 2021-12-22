using System;


namespace Minamespace
{
    class Clase1
    {
        public void Metodo()
        {
            Console.WriteLine("En MiNamespace");

        }
    }
}


namespace Otronamespace
{
    class Clase1
    {
        public void Metodo()
        {
            Console.WriteLine("En  Otronamespace");

        }
    }
}




namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creando objetos de clases contenidas en otro namespace
            Minamespace.Clase1 obj1 = new Minamespace.Clase1();
            Otronamespace.Clase1 obj2 = new Otronamespace.Clase1();

            obj1.Metodo();
            obj2.Metodo();

                
         }
    }
}
