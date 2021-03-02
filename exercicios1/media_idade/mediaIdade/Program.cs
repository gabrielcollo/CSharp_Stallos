using System;

namespace mediaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            double somaIdade = 0;
            int qtdIdade = 0;

            Console.WriteLine("Média de idades");
            Console.Write("Quantas notas deseja inserir? ");
            qtdIdade = int.Parse(Console.ReadLine());

            for (int cont = 1; cont <= qtdIdade; cont ++)
            {
                Console.Write($"Insira a idade do {cont}º aluno: ");
                somaIdade += double.Parse(Console.ReadLine());
            }

            Calcular calcular = new Calcular();

            double media = calcular.CalculoMedia(somaIdade, qtdIdade);

            Console.WriteLine("A média entre as idades inseridas é: " + media);

        }
    }
}
