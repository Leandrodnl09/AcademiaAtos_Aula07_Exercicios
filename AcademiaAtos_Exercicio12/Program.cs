namespace AcademiaAtos_Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 12. Apresentar o total da soma dos cem primeiros números inteiros.

            int sum = 0, i = 1; // Inicializa a variável de soma com o valor 0.

            while (i <= 100)
            { // Enquanto o contador for menor ou igual a 100.

                sum += i; // Adiciona o valor do contador à variável de soma.
                i++; // Incrementa o contador em 1.

            }

            Console.WriteLine("A soma dos cem primeiros números inteiros é: " + sum); // Apresenta o resultado.
        }
    }
}