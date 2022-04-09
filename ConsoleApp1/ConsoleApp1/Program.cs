using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter your name: ");
            var nombre=Console.ReadLine();
            Console.WriteLine($"Thanks for register, {nombre}");
        }
    }
}
