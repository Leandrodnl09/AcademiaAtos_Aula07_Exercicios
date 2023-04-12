namespace AcademiaAtos_Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8. Faça um programa em VS que solicite um numero inteiro. S
            // e o numero não for inteiro, solicite - o até que seja.após, informe se ele é par ou impar.
            // Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.

            bool repetir = true;

            while (repetir)
            {
                Console.Write("Digite um número inteiro: ");
                int numero;

                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("Número inválido. Digite novamente: ");
                }

                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par.");
                }
                else
                {
                    Console.WriteLine("O número é ímpar.");
                }

                Console.Write("Deseja repetir o programa? (S/N) ");
                string resposta = Console.ReadLine();

                if (resposta.ToUpper() != "S")
                {
                    repetir = false;
                }
            }
        }
    }
}