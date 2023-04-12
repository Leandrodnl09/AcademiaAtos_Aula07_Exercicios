namespace AcademiaAtos_Exerxixio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
            // coletando dados sobre o salário e número de filhos.A prefeitura deseja saber: 

            // a) média do salário da população;
            // b) média do número de filhos;
            // c) maior salário;
            // d) percentual de pessoas com salário até R$ 100,00.
            // O final da leitura de dados se dará com a entrada de um salário negativo.

            // Declaração das variáveis que serão utilizadas no programa
            double salario, somaSalario = 0, maiorSalario = 0;
            int numFilhos, numPessoas = 0, somaFilhos = 0, numPessoasAteCem = 0, cont = 1;

            // Solicita ao usuário que digite o salário da pessoa
            Console.WriteLine("Digite o salário da 1ª pessoa (negativo para encerrar):");

            // Lê o salário da pessoa informado pelo usuário
            salario = double.Parse(Console.ReadLine());

            // Início do loop que irá ler os dados de todas as pessoas
            while (salario >= 0)
            {
                // Solicita ao usuário que digite o número de filhos da pessoa
                Console.WriteLine($"Digite o número de filhos da {cont}ª pessoa:");
                numFilhos = int.Parse(Console.ReadLine());

                // Atualiza as variáveis de estatísticas
                somaSalario += salario;
                numPessoas++;
                somaFilhos += numFilhos;

                // Verifica se o salário atual é o maior já registrado
                if (salario > maiorSalario)
                {
                    maiorSalario = salario;
                }

                // Verifica se o salário atual é menor ou igual a R$ 100,00
                if (salario <= 100)
                {
                    numPessoasAteCem++;
                }

                // Solicita ao usuário que digite o salário da próxima pessoa
                Console.WriteLine($"Digite o salário da {cont + 1}ª pessoa (negativo para encerrar):");
                salario = double.Parse(Console.ReadLine());
                cont++;
            }

            // Cálculo das médias de salário e número de filhos
            double mediaSalario = somaSalario / numPessoas;
            double mediaFilhos = (double)somaFilhos / numPessoas;

            // Cálculo do percentual de pessoas com salário até R$ 100,00
            double percentualSalarioAteCem = (double)numPessoasAteCem / numPessoas * 100;

            // Apresentação das estatísticas
            Console.WriteLine($"Média do salário da população: R$ {mediaSalario.ToString("F2")}");
            Console.WriteLine($"Média do número de filhos: {mediaFilhos}");
            Console.WriteLine($"Maior salário: R$ {maiorSalario.ToString("F2")}");
            Console.WriteLine($"Percentual de pessoas com salário até R$ 100,00: {percentualSalarioAteCem.ToString("F2")}%");
        }
    }
}