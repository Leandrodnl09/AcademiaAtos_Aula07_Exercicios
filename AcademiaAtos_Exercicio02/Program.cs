using System.ComponentModel;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace AcademiaAtos_Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
            // (informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
            // Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

            // Exemplo:
            // Digite um número inteiro positivo: -8
            // Valor incorreto!
            // Digite um número inteiro positivo: 8
            // Numero digitado: 8
            // Números inteiros pares entre 1 e 8: 2, 4, 6.

            // 2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja
            // informar um outro número. Caso positivo, o programa em VS deve ser repetido.

            {
                do
                {
                    Console.Write("Digite um número inteiro positivo: ");
                    int num = int.Parse(Console.ReadLine());

                    Console.Write("Números pares entre 1 e {0}: ", num);
                    for (int i = 2; i <= num; i += 2)
                    {
                        Console.Write("{0} ", i);
                    }
                    Console.WriteLine();

                    Console.Write("Deseja informar outro número? (s/n) ");
                } while (Console.ReadLine().ToLower() == "s");
            }
        }
    }
}