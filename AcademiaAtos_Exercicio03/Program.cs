namespace AcademiaAtos_Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  3.Fazer um laço(repetição) que fique solicitando números ao usuário. 
            //  Se o usuário digitar 0 o programa em VS deve parar. 
            //  Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo

            int num;

            do
            {
                Console.Write("Digite um número (0 para sair): ");
                num = int.Parse(Console.ReadLine());

                if (num != 0)
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("O número é par");
                    }
                    else
                    {
                        Console.WriteLine("O número é ímpar");
                    }

                    bool isPrime = true;
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.WriteLine("O número é primo");
                    }
                    else
                    {
                        Console.WriteLine("O número não é primo");
                    }
                }
            } while (num != 0);
        }
    }
}