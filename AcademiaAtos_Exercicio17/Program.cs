namespace AcademiaAtos_Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 17. Apresentar os quadrados dos números inteiros de 15 a 200.

            // Inicialização da variável i com o valor 15
            int i = 15;

            // Loop while que itera pelos números inteiros de 15 a 200
            while (i <= 200)
            {
                // Cálculo do quadrado do número atual
                int quadrado = i * i;

                // Exibição do resultado na tela
                Console.WriteLine("O quadrado de " + i + " é " + quadrado);

                // Incremento da variável i
                i++;
            }
        }
    }
}