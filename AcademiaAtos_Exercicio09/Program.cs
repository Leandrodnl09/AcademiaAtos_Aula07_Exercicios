using System.Security.Cryptography;
using System;

namespace AcademiaAtos_Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
            // o zoológico num determinado dia, imprimindo:
            // Quantas pessoas tem entre 1 e 3 filhos.
            // Quantas pessoas tem entre 4 e 7 filhos.
            // Quantas pessoas tem mais de 8 filhos.
            // Quantas pessoas não tem filhos.

            int pessoasCom1a3Filhos = 0;
            int pessoasCom4a7Filhos = 0;
            int pessoasComMaisDe8Filhos = 0;
            int pessoasSemFilhos = 0;

            int i = 1;
            while (i <= 30)
            {
                Console.Write($"Digite a quantidade de filhos da {i}ª pessoa: ");
                int quantidadeDeFilhos = int.Parse(Console.ReadLine());

                if (quantidadeDeFilhos >= 1 && quantidadeDeFilhos <= 3)
                {
                    pessoasCom1a3Filhos++;
                }
                else if (quantidadeDeFilhos >= 4 && quantidadeDeFilhos <= 7)
                {
                    pessoasCom4a7Filhos++;
                }
                else if (quantidadeDeFilhos > 8)
                {
                    pessoasComMaisDe8Filhos++;
                }
                else if (quantidadeDeFilhos == 0)
                {
                    pessoasSemFilhos++;
                }

                i++;
            }

            Console.WriteLine($"Quantidade de pessoas com 1 a 3 filhos: {pessoasCom1a3Filhos}");
            Console.WriteLine($"Quantidade de pessoas com 4 a 7 filhos: {pessoasCom4a7Filhos}");
            Console.WriteLine($"Quantidade de pessoas com mais de 8 filhos: {pessoasComMaisDe8Filhos}");
            Console.WriteLine($"Quantidade de pessoas sem filhos: {pessoasSemFilhos}");

            Console.ReadLine();
        }
    }
}