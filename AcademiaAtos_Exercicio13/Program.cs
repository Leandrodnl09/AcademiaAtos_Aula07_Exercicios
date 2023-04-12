namespace AcademiaAtos_Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 13. Elaborar um programa que apresente o somatório dos valores pares existentes 
            // entre 1 e 500.

            // Declaração das variaveis.
            int numero = 1, soma = 0;

            while (numero <= 500)
            {
                if (numero % 2 == 0)
                {
                    soma += numero;
                }
                numero++;
            }
            Console.WriteLine($"A soma dos valores pares é: {soma}");

        }
    }
}