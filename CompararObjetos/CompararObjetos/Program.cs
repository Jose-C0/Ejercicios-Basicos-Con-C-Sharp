using System;

namespace CompararObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto p1 = new Producto { Codigo = "A1", Precio = 123 };
            Producto p2 = new Producto { Codigo = "A2", Precio = 34.5m };
            Producto p3 = new Producto { Codigo = "A3", Precio = 99.9m };

            Producto[] productos = new Producto[] { p1, p2, p3 };
            Array.Sort(productos);

            foreach (var prod in productos)
            {
                Console.WriteLine("Codigo: {0}, Precio: {1}", prod.Codigo, prod.Precio);

            }


        }
    }
}
