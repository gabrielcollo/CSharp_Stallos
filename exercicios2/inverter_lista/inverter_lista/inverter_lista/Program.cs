using System;
using System.Collections.Generic;

namespace inverter_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista invertida");

            List<int> listaNumeros = new List<int>();
            listaNumeros.AddRange(new[] {0, 3, 2, 1, 4, 5, 6, 8, 7});

            listaNumeros.Reverse();
            mostrarLista(listaNumeros);
        }

        private static void mostrarLista(List<int> listaNumeros)
        {
            Console.WriteLine(string.Join("-", listaNumeros.ToArray()));
        }
    }
}
