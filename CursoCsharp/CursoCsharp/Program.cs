using System;

namespace CursoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string nombre = "Stivens";
            var apellido = "Espinoza";

            Console.WriteLine($"Hello {nombre} {apellido}");
            Console.WriteLine($"Mi nombre tiene {nombre.Length} letras");
        }
    }
}
