using System;

namespace mediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            double somaNotas = 0;
            double media = 0;
            int qtdNotas = 0;

            Console.WriteLine("Média Aluno");
            Console.Write("Quantas notas deseja inserir? ");
            qtdNotas = int.Parse(Console.ReadLine());

            for (int cont = 1; cont <= qtdNotas; cont++)
            {
                Console.Write($"Insira a {cont}º nota do aluno: ");
                somaNotas += double.Parse(Console.ReadLine());
            }

            Calcular calcular = new Calcular();
            media = calcular.CalculoMedia(somaNotas, qtdNotas);

            if (media <= 3) Console.WriteLine($"A média é: {media}. Aluno Reprovado");
            if (media > 3 && media < 5) Console.WriteLine($"A média é: {media}. Aluno em recuperação");
            if(media >= 5 ) Console.WriteLine($"A média é: {media}. Aluno aprovado");

        }
    }
}
