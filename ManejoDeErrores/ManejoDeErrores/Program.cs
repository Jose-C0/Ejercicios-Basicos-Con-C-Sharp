using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeErrores
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Ingresa el numerador: ");
                int numerador = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el denominador: ");
                int denominador = int.Parse(Console.ReadLine());

                int resultado = numerador / denominador;
                Console.WriteLine("\nResultado: {0} / {1} = {2}", numerador, denominador, resultado);
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("\n"+ formatException.Message);
                Console.WriteLine("Debes ingreas dos enteros");
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("\n" + de.Message);
                Console.WriteLine("Cero es un denominador invalido");
            }
            catch (Exception e) //Exception (Atrapa cualquier error)     
            {
                Console.WriteLine("Algo ocurrio mal, intente de nuevo");
            }
            
        }
    }
}
