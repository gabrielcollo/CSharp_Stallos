using System;
using System.Collections.Generic;
using System.Linq;

namespace id_cliente
{
    class Program
    {
        public static void Main(string[] args)
        {
            SortedList<int, string> listaCliente = new SortedList<int, string>();
            listaCliente.Add(03, "João");
            listaCliente.Add(01, "Gabriel");
            listaCliente.Add(04, "Pedro");
            listaCliente.Add(02, "Dado");

            Console.Write("Quantos dados deseja inserir? ");
            int qtdDados = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < qtdDados; i++)
            {
                Console.Write("\nInsira o número do ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Insira o nome do cliente: ");
                string nome = Console.ReadLine();
                listaCliente.Add(id, nome);
            }
            
            mostrarLista(listaCliente.Values.ToList());              
        }

        private static void mostrarLista(List<string>listaCliente)
        {
            Console.WriteLine("\n" + string.Join("\n", listaCliente.ToArray()));
        }
    }


}
