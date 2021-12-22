using System;

namespace persona
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona ("Jhon", "Done", 28);
            Persona persona2 = new Persona("Jane", "Done", 27);

            persona1.Saludar();
            persona2.Saludar();

            persona1.Edad = -10;

            Console.WriteLine(persona1);

            Console.WriteLine(persona2);
            Console.Read();
        }
    }
}
