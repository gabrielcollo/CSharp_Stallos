using System;
using System.Collections.Generic;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada dos pares\n");

            Console.Write("Insira o valor mínimo: ");
            int valorMinimo = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor máximo: ");
            int valorMaximo = int.Parse(Console.ReadLine());

            List<string> listaTabuada = new List<string>();

            for(int i = valorMinimo; i <= valorMaximo; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine($"\n Tabuada do {i}");
                    for (int multiplicador = 1; multiplicador <=10; multiplicador++)
                    {
                        int valor = i * multiplicador;
                        Console.WriteLine($"{i} x {multiplicador} = {valor.ToString()}");
                    }
                }
            }
        }
    }
}
