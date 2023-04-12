using System.IO;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace AcademiaAtos_Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 20. Foi realizada uma pesquisa de algumas características físicas da população de uma 
            // certa região, a qual coletou os seguintes dados referentes a cada habitante para
            // serem analisados:
            // - sexo(masculino e feminino)
            // - cor dos olhos(azuis, verdes ou castanhos)
            // - cor dos cabelos(louros, castanhos, pretos)
            // - idade


            // Faça um algoritmo que determine e escreva:

            // - a maior idade dos habitantes
            // - a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
            // e que tenham olhos verdes e cabelos louros.
            // O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.


            int idade, maiorIdade = 0; // variáveis para armazenar a idade e a maior idade encontrada até o momento
            int mulheresVerdesLouros18a35 = 0, cont=1; // variável para armazenar a quantidade de mulheres com olhos verdes, cabelos louros e idade entre 18 e 35 anos inclusive
            string sexo, corOlhos, corCabelos; // variáveis para armazenar o sexo, cor dos olhos e cor dos cabelos


            Console.WriteLine("Informe os dados dos habitantes (-1 para finalizar):");

            while (true)
            { // laço de repetição para ler as informações de cada habitante
                Console.WriteLine($"{cont}º habitante: ");
                Console.Write("Sexo (M/F): ");
                sexo = Console.ReadLine().ToUpper(); // lê o sexo e converte para maiúsculas para facilitar a comparação posteriormente

                if (sexo == "-1")
                { // se o usuário informou -1 como idade, interrompe o laço de repetição
                    break;
                }

                Console.Write("Cor dos olhos (AZUL/VERDE/CASTANHO): ");
                corOlhos = Console.ReadLine().ToUpper(); // lê a cor dos olhos e converte para maiúsculas

                Console.Write("Cor dos cabelos (LOURO/CASTANHO/PRETO): ");
                corCabelos = Console.ReadLine().ToUpper(); // lê a cor dos cabelos e converte para maiúsculas

                Console.Write("Idade: ");
                idade = int.Parse(Console.ReadLine()); // lê a idade como uma string e converte para um valor numérico

                if (idade > maiorIdade)
                { // verifica se a idade atual é maior do que a maior idade encontrada até o momento
                    maiorIdade = idade; // se sim, atualiza a maior idade
                }

                if (sexo == "F" && idade >= 18 && idade <= 35 && corOlhos == "VERDE" && corCabelos == "LOURO")
                {
                    // verifica se o habitante é do sexo feminino, tem olhos verdes, cabelos louros e idade entre 18 e 35 anos inclusive
                    mulheresVerdesLouros18a35++; // se sim, incrementa a variável de contagem
                }
                cont++;
            }

            Console.WriteLine("Maior idade: " + maiorIdade); // exibe a maior idade encontrada
            Console.WriteLine("Mulheres com olhos verdes, cabelos louros e idade entre 18 e 35 anos: " + mulheresVerdesLouros18a35); // exibe a quantidade de mulheres que atendem às características específicas
        }
    }
    
}