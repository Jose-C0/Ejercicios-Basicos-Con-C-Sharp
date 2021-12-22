using System;
using System.Text;

namespace Tabla_de_multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            string RepeatCharacterTimes(char character, int times)
            {
                StringBuilder builder = new StringBuilder("s");
                for (int counter = 0; counter < times; counter++)
                {
                    //Append one instance of the character to the StringBuilder.
                    builder.Append(character);
                    Console.WriteLine(builder);

                }
                //Convert the result to string and return it.
                return builder.ToString();

            }


        }
    }
}
