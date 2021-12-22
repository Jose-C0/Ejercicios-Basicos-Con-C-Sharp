using System;

namespace PromedioCalificaciones
{
    class Program
    {

        public static void EscribirNumeroReal(float n)
        {
            Console.WriteLine(n.ToString("#.###"));
        }
        static void Main(string[] args)
        {

           
            
                float x;
                x = 5.1f;
                Console.WriteLine("El primer numero real es: ");
                EscribirNumeroReal(x);
                Console.WriteLine(" y otro distinto es: ");
                EscribirNumeroReal(2.3f);
            

        }










        //Console.Write("Numero de Calificaciones a ingresar: ");
        //int num = int.Parse(Console.ReadLine());

        //int[] calificaciones = new int[num];

        //double suma = 0;
        //for (int i = 0; i < calificaciones.Length; i++)
        //{
        //    Console.Write("Calificacion {0}: ", i + 1);
        //    calificaciones[i] = int.Parse(Console.ReadLine());
        //    suma += calificaciones[i];

        //}
        //double promedio = suma / calificaciones.Length;
        //Console.WriteLine("El promedio es: {0}:", promedio);
        Console.Read();
        }
        
       

    }
}
