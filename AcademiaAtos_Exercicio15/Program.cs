using System.Runtime.ConstrainedExecution;

namespace AcademiaAtos_Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
            // ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente.
            // Considerar nota 7,0 como mínima para aprovação.

            double nota1, nota2, nota3, nota4;
            double media;
            bool notaInvalida;

            do
            {
                // Inicializa a variável notaInvalida como falsa a cada iteração do loop
                notaInvalida = false;

                Console.WriteLine("Digite as notas do aluno:");
                Console.Write("Nota 1: ");
                nota1 = double.Parse(Console.ReadLine());
                Console.Write("Nota 2: ");
                nota2 = double.Parse(Console.ReadLine());
                Console.Write("Nota 3: ");
                nota3 = double.Parse(Console.ReadLine());
                Console.Write("Nota 4: ");
                nota4 = double.Parse(Console.ReadLine());

                // Verifica se alguma nota é menor que zero ou maior que dez
                if (nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10 || nota3 < 0 || nota3 > 10 || nota4 < 0 || nota4 > 10)
                {
                    Console.WriteLine("Alguma nota está fora do intervalo (0, 10)!");
                    notaInvalida = true;
                }
            } while (notaInvalida);

            media = (nota1 * 2 + nota2 * 1 + nota3 * 2 + nota4 * 4) / 9;

            Console.WriteLine("Média: " + media.ToString("F1"));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado!");
            }
            else
            {
                Console.WriteLine("Aluno reprovado!");
            }
        }
    }
}