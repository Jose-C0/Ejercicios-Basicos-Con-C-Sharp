using System;

namespace ClaseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenacion de cadenas
            Console.WriteLine("Hola"+ "mundo");
            Console.WriteLine(string.Concat("Hola", "mundo"));

            string cadena = "Esta es una cadena de prueba";
            Console.WriteLine(cadena);
            Console.WriteLine("Tamaño:"+ cadena.Length);
            Console.WriteLine("Mayuscula:" + cadena.ToUpper());
            Console.WriteLine("Minuscula:" + cadena.ToLower());

            //Metodo Replace
            Console.WriteLine("Replace:" + cadena.Replace(" ", ""));
            Console.WriteLine("Caracter en indice 0:" + cadena[0]);
            Console.WriteLine("Caracter en indice 1:" + cadena[1]);


            //Metodo Substring
            Console.WriteLine("Substring (1-8):"+ cadena.Substring(1, 8));

            //Metodo Contains
            Console.WriteLine("cadena contiene \"es\"?" + cadena.Contains("es"));

            //Metodo StartWish
            Console.WriteLine("Cadena empieza \"La\"? " + cadena.StartsWith("La"));

            //Verificar si una cadena es nula o vacia
            string nula = null;
            Console.WriteLine("nula es null?" + string.IsNullOrEmpty(nula));
            Console.WriteLine("cadena es null?" + string.IsNullOrWhiteSpace(cadena));

            //Obtener posicion de un dato
            Console.WriteLine("Posicion de la cadena \"de\": "+ cadena.IndexOf("de") );





        }
    }
}
