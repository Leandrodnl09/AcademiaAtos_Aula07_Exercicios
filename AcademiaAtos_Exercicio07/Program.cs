using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace AcademiaAtos_Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
            // A cada solicitação, teste se o usuário informou um valor válido. 
            // Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
            // informe que ele está incorreto e saia do programa em VS.
            // Se o nome for lido corretamente, solicite a idade.Se ela for incorreta(menor ou igual a zero),
            // informe que está errada e saia.Se estiver correta, solicite o salário.
            // Se ele estiver incorreto(menor ou igual a zero), informe que está incorreto e saia.
            // Se estiver correto, mostre todos os valores lidos.

            string nome = "";
            int idade = 0;
            double salario = 0;

            while (string.IsNullOrWhiteSpace(nome))
            {
                Console.Write("Digite o nome: ");
                nome = Console.ReadLine();
                bool temNumero = nome.Any(char.IsDigit);
                if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome) || temNumero == true)
                {
                    Console.WriteLine("Nome incorreto!");
                    nome = "";
                }
            }

            while (idade <= 0)
            {
                Console.Write("Digite a idade: ");
                if (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
                {
                    Console.WriteLine("Idade incorreta!");
                    idade = 0;
                }
            }

            while (salario <= 0)
            {
                Console.Write("Digite o salário: ");
                if (!double.TryParse(Console.ReadLine(), out salario) || salario <= 0)
                {
                    Console.WriteLine("Salário incorreto!");
                    salario = 0;
                }
            }

            Console.WriteLine($"Nome: {nome}, Idade: {idade}, Salário: {salario.ToString("F2")}");
        }
    }
}