namespace AcademiaAtos_Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
            // elevada a um expoente qualquer, ou seja, N M.

            Console.WriteLine("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o expoente: ");
            int expoente = int.Parse(Console.ReadLine());
            int mostrarExpoente = expoente; // variavel para mostrar na tela o expoente

            // variável para armazenar o resultado
            double resultado = 1;

            // loop while para calcular a potência
            while (expoente > 0)
            {
                resultado *= baseNum;
                expoente--;
            }

            Console.WriteLine("{0} elevado a {1} é igual a {2}", baseNum, mostrarExpoente, resultado);

        }
    }
}