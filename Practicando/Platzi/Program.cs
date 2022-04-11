using System;
using System.Collections.Generic;
using System.Linq;
namespace Platzi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            List<string> listaMenu = new List<string>() { 
                "huancaina",
                "ceviche",
                "pachamanca"
            };
            List<string> orderList = new List<string>();
            string continuar="si";
            while (continuar.ToLower() == "si")
            {
                Console.WriteLine("Menu:");
                foreach (string item in listaMenu)
                {
                    Console.WriteLine($"*{item}\t");
                }
                Console.Write("Ingrese su orden: ");
                string findMenu = Console.ReadLine();
                var selected = listaMenu.Contains(findMenu.ToLower());
                if (selected)
                {
                    orderList.Add(findMenu);
                }

                Console.WriteLine("Desea continuar ? 1=si, (Cualquier otro numero o letra)=no");
                continuar = Console.ReadLine();
            }
            Console.WriteLine("Su orden esta siendo procesada....");
            foreach (var order in orderList)
            {
                Console.WriteLine($"**{order}\t");
            }
            
        }
    }
}
