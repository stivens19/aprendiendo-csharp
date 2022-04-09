using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string numeroString = Console.ReadLine();
                int numero = int.Parse(numeroString);
                Console.WriteLine($"Se ha escrito {numero}");
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("El dato ingresado no es un numero");

                #if debug
                Console.WriteLine(formatException.Message);
                #endif
            }
            catch (Exception ex)
            {

                Console.Write($"Ocurrio un error {ex}");
            }
           
        }
    }
}
