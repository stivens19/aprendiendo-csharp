using System;
using System.Collections.Generic;

namespace CsharpColecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] lista = new int[5] { 4, 3, 2, 5, 1 };

            //int[,] numbers2D = new int[5, 5];
            //for (int i = 0; i < numbers2D.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers2D.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Ingrese numero posicion {i}-{j}");
            //        numbers2D[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < numbers2D.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers2D.GetLength(1); j++)
            //    {
            //        Console.Write($"{numbers2D[i,j]} \t");
            //    }
            //    Console.WriteLine();
            //}
            //int[] listaNumeros = new int[5];

            //for (int i = 0; i < listaNumeros.Length; i++)
            //{
            //    Console.WriteLine($"Ingrese el numero de la Posicion {i}");
            //    listaNumeros[i] = int.Parse(Console.ReadLine());
            //}

            //foreach (int item in listaNumeros)
            //{
            //    Console.WriteLine(item);
            //}
            //Dictionary<int, int> listaDatos = new Dictionary<int, int>();

            //string valorDigitado = "";
            //while (valorDigitado != ".")
            //{
            //    Console.WriteLine("Ingrese un numero o .para finalizar");
            //    valorDigitado = Console.ReadLine();
            //    if(valorDigitado != ".")
            //    {
            //        listaDatos.Add(int.Parse(valorDigitado), int.Parse(valorDigitado));
            //    }
            //}

            //foreach (var item in listaDatos)
            //{
            //    Console.WriteLine($"Clave: {item.Key} Valor: {item.Value}");
            //}


            List<short> listaPorcentajes = new List<short>();
            listaPorcentajes.Add(50);
            listaPorcentajes.Add(30);
            listaPorcentajes.Add(70);

            Console.WriteLine($"Mi lista contiene {listaPorcentajes.Count}");
            Console.WriteLine($"lista contiene {listaPorcentajes.Contains(70)}");
            foreach (var item in listaPorcentajes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
