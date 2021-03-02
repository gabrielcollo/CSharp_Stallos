using System;

namespace par_ou_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Par ou Impar");

            Console.Write("Insira um valor: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor % 2 == 0) Console.WriteLine("O valor iserido é par!");
            else Console.WriteLine("O valor iserido é impar!");
        }
    }
}
