namespace AcademiaAtos_Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
            // ou seja, repita a leitura até que ela esteja correta(maior do que zero). 
            // Ao final, mostre a idade digitada.

            int idade = 0;

            while (idade <= 0)
            {
                Console.Write("Digite a idade: ");

                if (!int.TryParse(Console.ReadLine(), out idade))
                {
                    Console.WriteLine("Entrada inválida. Digite um número inteiro válido.");
                }
                else if (idade <= 0)
                {
                    Console.WriteLine("A idade deve ser maior do que zero. Digite novamente.");
                }
            }

            Console.WriteLine("Idade digitada: " + idade);
        }
    }
}