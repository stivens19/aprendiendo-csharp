using System;

namespace CsharpCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresesu edad: ");
            var edadUsuarioString = Console.ReadLine();
            string mensaje=int.TryParse(edadUsuarioString, out int edadUsuario) ? "Calculando edad..." : "Es un string";

            Console.WriteLine(mensaje);
            if (mensaje == "Es un string") return;
            if (edadUsuario >= 18 )
            {
                Console.WriteLine($"Su edad de {edadUsuario} años indica que es mayor de edad.");
                if (edadUsuario>=65)
                {
                    Console.WriteLine("Haces parte de la tercera edad");
                }
            }
            else if(edadUsuario<=16)Console.WriteLine("Esta en el colegio.");
        }
    }
}
